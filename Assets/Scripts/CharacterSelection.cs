using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelection : MonoBehaviour
{
	public GameObject[] characters;
	public TextMeshProUGUI Name;
	public int selectedCharacter = 0;
    public void Start()
    {
		StaticClass.ActualMax = characters.Length;
		
    }
    public void NextCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter = (selectedCharacter + 1) % StaticClass.Maxcharselect;
		characters[selectedCharacter].SetActive(true);
		string Text = characters[selectedCharacter].ToString();
		Text = Text.Replace("(UnityEngine.GameObject)","");
		Name.text = "Selected: "+Text;
	}

	public void PreviousCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter--;
		if (selectedCharacter < 0)
		{
			selectedCharacter += StaticClass.Maxcharselect;
		}
		characters[selectedCharacter].SetActive(true);
		string Text = characters[selectedCharacter].ToString();
		Text = Text.Replace("(UnityEngine.GameObject)", "");
		Name.text = "Selected: " + Text;
	}

	public void StartGame()
	{
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		SceneManager.LoadScene("Level_1", LoadSceneMode.Single);
	}
}
