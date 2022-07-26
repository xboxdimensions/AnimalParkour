using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public float rotateSpeed;
    public string nextSceneName;
    public bool lastLevel;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // did the player enter our trigger?
        if(other.CompareTag("Player"))
        {
            Debug.Log("Hit");
            // is this the last level?
            if(lastLevel == true)
            {
                SceneManager.LoadScene(0);
            }
            // is there another scene/level we can go to?
            else
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}



