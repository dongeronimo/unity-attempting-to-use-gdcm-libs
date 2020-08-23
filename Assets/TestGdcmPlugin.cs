using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;

public class TestGdcmPlugin : MonoBehaviour
{
    /// <summary>
    /// Indicates the state of the load process
    /// </summary>
    public enum DirectoryLoadingState {DIDNT_BEGUN, LOADING, LOADED };
    private DirectoryLoadingState loadingState = DirectoryLoadingState.DIDNT_BEGUN;

    private DirectoryReaderService directoryReaderService = new DirectoryReaderService();
    List<PathAndData> sortedFiles = null;
    // Start is called before the first frame update
    void Start()
    {
        Thread thread = new Thread(() =>
        {
            loadingState = DirectoryLoadingState.LOADING;
            List<PathAndData> sortedFileList = directoryReaderService.readDirectory("C:/dicoms/COU IV");
            sortedFiles = sortedFileList;
            loadingState = DirectoryLoadingState.LOADED;
        });
        thread.Start();
    }

    // Update is called once per frame
    bool alredyPrinted = false;
    void Update()
    {
        if(!alredyPrinted)
            Debug.Log(loadingState);
        if(loadingState == DirectoryLoadingState.LOADED && alredyPrinted == false)
        {
            foreach(var f in sortedFiles)
            {
                Debug.Log("Name = " + f.patient + ", imagePosition = " + f.position[0] + ", " + f.position[1] + ", " + f.position[2]);
            }
            alredyPrinted = true;
        }
    }
}