using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class TestGdcmPlugin : MonoBehaviour
{
    private DirectoryReaderService directoryReaderService = new DirectoryReaderService();

    // Start is called before the first frame update
    void Start()
    {
        gdcm.FilenamesType sortedFiles = directoryReaderService.readDirectory("C:/dicoms/teste_unity");
        foreach(var f in sortedFiles)
        {
            Debug.Log(f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}