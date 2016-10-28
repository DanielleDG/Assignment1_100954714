using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour {

	[SerializeField]
	Button playBtn = null;
	[SerializeField]
	Button howToBtn = null;

	public void StartGame(){
		SceneManager.LoadScene ("GameScene");
	}
	public void Directions(){
		SceneManager.LoadScene ("HelpScreen");
	}
}
