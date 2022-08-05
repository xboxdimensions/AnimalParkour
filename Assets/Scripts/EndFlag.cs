using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public string nextSceneName;
    public bool lastLevel;

    private void OnTriggerEnter(Collider other)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (other.CompareTag("Player"))
        {
            if (StaticClass.Maxcharselect < StaticClass.ActualMax)
            {
                if (scene.name == "Level_1")
                {
                    StaticClass.Maxcharselect = 3;
                }
                else if (scene.name == "Level_2")
                {
                    StaticClass.Maxcharselect = 4;
                }
                else if (scene.name == "Level_3")
                {
                    StaticClass.Maxcharselect = 5;
                }
                else if (scene.name == "Level_4")
                {
                    StaticClass.Maxcharselect = 6;
                }
                else if (scene.name == "Level_5")
                {
                    StaticClass.Maxcharselect = 7;
                }
            }
            if (lastLevel == true) { SceneManager.LoadScene("Yay");StaticClass.Walknow = false; }
            else { SceneManager.LoadScene(nextSceneName); }
        }
    }
    void Update()
    {
        transform.Rotate(Vector3.up, 180 * Time.deltaTime);
    }
}
