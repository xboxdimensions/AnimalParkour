using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton ()
    {
        Application.Quit();
    }
    public void OnInfoButton()
    {
        SceneManager.LoadScene("Info");
    }
    public void OnHelpButton()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
