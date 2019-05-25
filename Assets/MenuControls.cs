using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour {

    public void PlayPressed()
    {
        SceneManager.LoadScene("game");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
    public void SettingsPressed()
    {
        SceneManager.LoadScene("sett");
    }
}
