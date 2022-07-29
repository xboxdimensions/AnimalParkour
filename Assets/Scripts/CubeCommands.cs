using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;
public class CubeCommands : MonoBehaviour
{
    public Material[] newMaterialRef;
    Renderer rend;
    private int Type;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        Type = UnityEngine.Random.Range(StaticClass.MinWords, StaticClass.MaxWords+1);
        rend.sharedMaterial = newMaterialRef[Type];
        //Debug.Log(Type);
        

    }

    public static int GetUnixTime()
    {
        return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
    }
    public void OnMouseDown()
    {
        Debug.Log(Type);
        //if (StaticClass.ID == StaticClass.Type)
        //{
        //    Debug.Log("Stand here");
        //}
        //if (StaticClass.Type == StaticClass.MaxWords)
        //{
        //    Debug.Log("Same");
        //    StaticClass.Type++;
        //}
    }

    void OnCollisionEnter(Collision collision)
    {
     //   if (collision.gameObject.CompareTag("Player"))
        {
            if (StaticClass.ID != Type)
            {
                StaticClass.Lives--;
                //Debug.Log(StaticClass.ID);
                //Debug.Log(StaticClass.Type);
                collision.gameObject.transform.position = new Vector3(0,0,0);
            }

        }
    }
}

