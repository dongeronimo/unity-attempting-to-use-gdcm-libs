using gdcm;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectoryReaderService
{
    public FilenamesType readDirectory(string path)
    {
        return GetFilteredFiles(path);
    }

    gdcm.FilenamesType GetFilteredFiles(string path)
    {
        gdcm.FilenamesType unsortedFiles = GetUnsortedFilenameList(path);
        gdcm.Scanner scanner = PrepareFileScanner();
        gdcm.FilenamesType filteredFiles = ScanFiles(scanner, unsortedFiles);
        return filteredFiles;
    }

    /**Returns the unsorted files list in the given directory. This list is not filtered 
     * (that means that the list may have non-dicom files) nor sorted.*/
    private gdcm.FilenamesType GetUnsortedFilenameList(string path)
    {
        gdcm.Directory dir = new gdcm.Directory();
        dir.Load(path);
        gdcm.FilenamesType unsortedFiles = dir.GetFilenames();
        return unsortedFiles;
    }
    /// <summary>
    /// Creates a file scanner that reads the tags that I use to sort the files.
    /// </summary>
    /// <returns>The file scanner.</returns>
    private gdcm.Scanner PrepareFileScanner()
    {
        gdcm.Scanner s0 = new gdcm.Scanner();
        s0.AddTag(Tags.StudyInstanceUID);
        s0.AddTag(Tags.SeriesInstanceUID);
        s0.AddTag(Tags.PatientName);
        s0.AddTag(Tags.DirectionCosines);
        s0.AddTag(Tags.ImagePosition);
        return s0;
    }
    /// <summary>
    /// Scan the given directory with the given scanner returning the only the files that
    /// have the tags on the given scanner. 
    /// </summary>
    /// <param name="scanner">The scanner with the tags</param>
    /// <param name="directory">The directory to be scanned</param>
    /// <returns>The file list without the files that don't have the tags.</returns>
    gdcm.FilenamesType ScanFiles(gdcm.Scanner scanner, gdcm.FilenamesType directory)
    {
        bool b = scanner.Scan(directory);
        if (!b)
        {
            throw new FileScanException(directory.First());
        }
        return scanner.GetKeys();
    }
    gdcm.Reader CreateReader(string path)
    {
        gdcm.Reader reader = new gdcm.Reader();
        reader.SetFileName(path);
        bool canRead = reader.Read();
        if (!canRead)
        {
            throw new CouldNotReadGDCMFileException(path);
        }
        return reader;
    }
    gdcm.DataSet GetDatasetFromFile(string path)
    {
        gdcm.Reader reader = CreateReader(path);
        gdcm.File file = reader.GetFile();
        return file.GetDataSet();
    }
    string GetPatientName(gdcm.DataSet dataset)
    {
        //Os mecanismos de gdcm::Attribute tb estão quebrados.
        gdcm.DataElement element = dataset.GetDataElement(Tags.PatientName);
        return element.GetValue().toString();
    }
    string GetStudyUid(gdcm.DataSet dataset)
    {
        gdcm.DataElement element = dataset.GetDataElement(Tags.StudyInstanceUID);
        return element.GetValue().toString();
    }

    string GetSeriesUid(gdcm.DataSet dataset)
    {
        gdcm.DataElement element = dataset.GetDataElement(Tags.SeriesInstanceUID);
        return element.GetValue().toString();
    }
    float[] GetImagePosition(gdcm.DataSet dataset)
    {
        gdcm.DataElement element = dataset.GetDataElement(Tags.ImagePosition);
        string valueAsString = element.GetByteValue().toString();
        var partsAsString = valueAsString.Split('\\');
        var partsAsFloat = partsAsString.Select(part => float.Parse(part)).ToArray();
        return partsAsFloat;
    }
    float[] GetDirectionCosines(gdcm.DataSet dataset)
    {
        string valueAsString = dataset.GetDataElement(Tags.DirectionCosines).GetByteValue().toString();
        var partsAsString = valueAsString.Split('\\');
        var partsAsFloat = partsAsString.Select(part => float.Parse(part)).ToArray();
        return partsAsFloat;
    }
    gdcm.FilenamesType SortFilenames(gdcm.FilenamesType files)
    {
        //Os mecanismos de sorting da gdcm estão quebrados na interface da swig. Terei que fazer o sorting na mão
        //1)Sort por paciente
        files.ToList().Sort((string file1, string file2) =>
        {
            gdcm.DataSet ds1 = GetDatasetFromFile(file1);
            string p1Name = GetPatientName(ds1);
            string p1Study = GetStudyUid(ds1);
            string p1Series = GetSeriesUid(ds1);
            float[] p1Position = GetImagePosition(ds1);
            float[] image1OrientationPlane = GetDirectionCosines(ds1);

            gdcm.DataSet ds2 = GetDatasetFromFile(file2);
            string p2Name = GetPatientName(ds2);
            string p2Study = GetStudyUid(ds2);
            string p2Series = GetSeriesUid(ds2);
            float[] p2Position = GetImagePosition(ds2);
            float[] p2DirectionCosine = GetDirectionCosines(ds2);

            int nameComparison = p1Name.CompareTo(p2Name);
            int studyComparison = p1Study.CompareTo(p2Study);
            int seriesComparison = p1Series.CompareTo(p2Series);

            double[] normal = new double[3];
            normal[0] = image1OrientationPlane[1] * image1OrientationPlane[5] - image1OrientationPlane[2] * image1OrientationPlane[4];
            normal[1] = image1OrientationPlane[2] * image1OrientationPlane[3] - image1OrientationPlane[0] * image1OrientationPlane[5];
            normal[2] = image1OrientationPlane[0] * image1OrientationPlane[4] - image1OrientationPlane[1] * image1OrientationPlane[3];
            double dist1 = 0;
            for (var i = 0; i < 3; ++i) dist1 += normal[i] * p1Position[i];
            double dist2 = 0;
            for (var i = 0; i < 3; ++i) dist2 += normal[i] * p2Position[i];
            int imagePositionComparison = dist1.CompareTo(dist2);

            if (nameComparison != 0) return nameComparison;//Se o nome é diferente retorna a comparacao do nome
            if (studyComparison != 0) return studyComparison;//Se o nome é igual e o estudo é diferente retorna a comparação do estudo
            if (seriesComparison != 0) return seriesComparison;//Se o nome e o estudo são iguais e a serie é diferente retorna a comparacao da serie.
            //Se o nome, estudo e série são iguais retorna a comparação da image position
            return imagePositionComparison;

        });
        return files;
    }
}
