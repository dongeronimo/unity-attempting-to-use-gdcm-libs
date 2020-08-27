using PowerUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImageLoadSceneGUIViewController : MonoBehaviour
{
    private MyGdcmPlugin gdcmPlugin;
    private HtmlDocument document;
    // Start is called before the first frame update
    void Start()
    {
        gdcmPlugin = GetComponent<MyGdcmPlugin>();
        document = GetComponent<Manager>().document;
    }
    private void Update()
    {
        UpdateProgressBarWithMyGDCMLoadProgress();
        HideProgressBarAndGoToNextSceneWhenLoadDone();
    }

    private void UpdateProgressBarWithMyGDCMLoadProgress()
    {
        string widthStr = BuildWidthCssString();
        ApplyWidthChange(widthStr);
    }
    private string BuildWidthCssString()
    {
        float progress = gdcmPlugin.LoadProgress * 100;
        string progressStr = string.Format("{0}%", Mathf.RoundToInt(progress));
        return progressStr;
    }
    private void ApplyWidthChange(string widthStr)
    {
        var progressBarInnerProgress = document.getElementById("progress-bar-progress");
        progressBarInnerProgress.style.width = widthStr;
    }
    //TODO: Tirar a animação do html e por no c#.

    private void HideProgressBarAndGoToNextSceneWhenLoadDone()
    {
        if (gdcmPlugin.LoadingState == MyGdcmPlugin.DirectoryLoadingState.LOADED)
        {

            Dom.Element progressBar = document.getElementById("progress-bar-container");
            progressBar.style.animation = "fade-progress-bar 1s";
            //TODO: Essa condição está mto fragil. Usar uma condição melhor
            if (progressBar.style.backgroundColor == "rgba(0,1686275,0,1686275,0,1686275,0)")
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

}
