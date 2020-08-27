using PowerUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void HideProgressBarAndGoToNextSceneWhenLoadDone()
    {
        if (gdcmPlugin.LoadingState == MyGdcmPlugin.DirectoryLoadingState.LOADED)
        {
            Dom.Element progressBar = document.getElementById("progress-bar-container");
            progressBar.style.animation = "fade-progress-bar 1s";
            
        }
    }

}
