using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setting : MonoBehaviour {

    public void BackPressed()
    {
        SceneManager.LoadScene("menu");
    }
    public bool isFullScreen;
    
    public void FullScreenToggle()
    {
        if (isFullScreen = !isFullScreen)
            Screen.fullScreen = isFullScreen;
        else isFullScreen = !Screen.fullScreen;
    }
}
