using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharSelect : MonoBehaviour
{
    public void SelectColum()
    {
       // StaticClass.PlayerMesh = "Columbus";
        SceneManager.LoadScene(0);
    }

    public void SelectCrew()
    {
        //StaticClass.PlayerMesh = "Crewmate";
        SceneManager.LoadScene(0);
    }

    public void OnBackButton ()
    {
        SceneManager.LoadScene(0);
    }
}
