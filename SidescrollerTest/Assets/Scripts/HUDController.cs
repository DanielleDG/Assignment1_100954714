using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text PointsLabel = null;
	[SerializeField]
	Text HealthLabel = null;
	[SerializeField]
	GameObject player = null;
	[SerializeField]
	Button restartBtn = null;

	public void UpdatePoints(){

		PointsLabel.text = "Points: " + Player.Instance.Points;

	}

	public void UpdateHealth(){

		HealthLabel.text = "Health: " + Player.Instance.Health;
	}

	// Use this for initialization
	void Start () {
		Player.Instance.hud = this;
		Restart ();
	}

	public void GameOver(){
		PointsLabel.gameObject.SetActive (false);
		HealthLabel.gameObject.SetActive (false);
		player.SetActive (false);

		restartBtn.gameObject.SetActive (true);


	}

	public void Restart(){
		PointsLabel.gameObject.SetActive (true);
		HealthLabel.gameObject.SetActive (true);

		Player.Instance.Points = 0;
		Player.Instance.Health = 100;

		restartBtn.gameObject.SetActive (false);
	}





}
