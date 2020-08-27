using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;

public class MyGdcmPlugin : MonoBehaviour
{
    /// <summary>
    /// Indicates the state of the load process
    /// </summary>
    public enum DirectoryLoadingState {DIDNT_BEGUN, LOADING, LOADED };
    public DirectoryLoadingState LoadingState = DirectoryLoadingState.DIDNT_BEGUN;
    public float LoadProgress = 0.0f;
    public string LoadStep = "";
    public List<PathAndData> SortedFiles = null;
    private readonly DirectoryReaderService directoryReaderService = new DirectoryReaderService();
    
    // Start is called before the first frame update
    void Start()
    {
        //Loads in a separate thread because the IO hangs the thread. Don't have to care about thread semaphores because the only thread that updates sortedFiles, loadingState, LoadProgress, LoadStep
        //is this thread and value attribution to refs and primitive variables is atomic in C#.
        Thread imageDirectoryWorkerThread = new Thread(() =>
        {
            LoadingState = DirectoryLoadingState.LOADING;
            //Load and sort the files. They will be sorted by patient, study, series, image position. As the load progresses it updates the load progress and the load step.
            List<PathAndData> sortedFileList = directoryReaderService.readDirectory("C:/dicoms/COU IV", (float progress, string step) => {
                LoadProgress = progress;
                LoadStep = step;
                return progress; 
            });
            //The files are loaded and sorted: Time to set the variable and finish the loading process
            SortedFiles = sortedFileList;
            LoadingState = DirectoryLoadingState.LOADED;
        });
        imageDirectoryWorkerThread.Start();
    }

}