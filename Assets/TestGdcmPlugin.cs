using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;

public class TestGdcmPlugin : MonoBehaviour
{
    private DirectoryReaderService directoryReaderService = new DirectoryReaderService();
    gdcm.FilenamesType sortedFiles = null;
    // Start is called before the first frame update
    void Start()
    {
        Thread thread = new Thread(() =>
        {
            gdcm.FilenamesType sortedFileList = directoryReaderService.readDirectory("C:/dicoms/teste_unity");
            sortedFiles = sortedFileList;
        });
        thread.Start();
        //gdcm.FilenamesType sortedFiles = directoryReaderService.readDirectory("C:/dicoms/teste_unity");
        //foreach(var f in sortedFiles)
        //{
        //    Debug.Log(f);
        //}
    }
    bool alredyPrinted = false;
    // Update is called once per frame
    void Update()
    {
        if (alredyPrinted) return;
        if(sortedFiles != null)
        {
            foreach (var f in sortedFiles)
            {
                Debug.Log(f);
            }
            alredyPrinted = true;
        }
        else
        {
            Debug.Log("loading...");
        }
    }
}