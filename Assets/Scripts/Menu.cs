using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Start()
    {
        if (StaticClass.Maxcharselect == 0)
        {
            StaticClass.Maxcharselect = 2;
        }
    }
    public void OnPlayButton ()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void OnQuitButton ()
    {
        Application.Quit();
    }
    public void OnInfoButton()
    {
        SceneManager.LoadScene("Info_1");
    }
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Help()
    {
        SceneManager.LoadScene("Help");
    }
}
