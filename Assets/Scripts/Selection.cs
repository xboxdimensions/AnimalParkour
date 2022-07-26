using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selection : MonoBehaviour
{
    public void OnYugaraButton ()
    {   
        StaticClass.CrossSceneInformation = "Yugara";
        SceneManager.LoadScene(2);
    }

    public void OnYugurabulButton ()
    {
        StaticClass.CrossSceneInformation = "Yugarabul";
        SceneManager.LoadScene(2);
    }
    public void OnYugambehButton ()
    {
        StaticClass.CrossSceneInformation = "Yugambeh";
        SceneManager.LoadScene(2);
    }
    public void OnTurubulButton ()
    {
        StaticClass.CrossSceneInformation = "Turubul";
        SceneManager.LoadScene(2);
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }
}
