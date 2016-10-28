using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DirectionsMenu : MonoBehaviour {

	[SerializeField]
	Button backToMain = null;

	public void BackToMain(){
		SceneManager.LoadScene ("WelcomeScreen");
	}

}
