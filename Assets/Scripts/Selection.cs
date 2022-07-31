using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selection : MonoBehaviour
{
    public void OnYugaraButton ()
    {   
        StaticClass.CrossSceneInformation = "Yugara";
        SceneManager.LoadScene("NewCharSelection");
    }

    public void OnYugurabulButton ()
    {
        StaticClass.CrossSceneInformation = "Yugarabul";
        SceneManager.LoadScene("NewCharSelection");
    }
    public void OnYugambehButton ()
    {
        StaticClass.CrossSceneInformation = "Yugambeh";
        SceneManager.LoadScene("NewCharSelection");
    }
    public void OnTurubulButton ()
    {
        StaticClass.CrossSceneInformation = "Turubul";
        SceneManager.LoadScene("NewCharSelection");
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }
}
