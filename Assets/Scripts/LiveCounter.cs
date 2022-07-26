using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class LiveCounter : MonoBehaviour
{
    public TextMeshProUGUI Lives;
    public int MaxLives = 3;
    // Start is called before the first frame update
    void Start()
    {
    StaticClass.Lives = MaxLives;
    
    }

    // Update is called once per frame
    void Update()
    {
        Lives.text = "Lives: " + StaticClass.Lives.ToString();
        if (StaticClass.Lives <= 0)
        {
            SceneManager.LoadScene("YouLose");
        }
    }
}
