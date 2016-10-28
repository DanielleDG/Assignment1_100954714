using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	[SerializeField]


	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "prize") {
			Debug.Log ("Collision with "+ other.gameObject.tag);
			Player.Instance.Points += 10;
			AudioSource coinSound =
				gameObject.GetComponent<AudioSource> ();
			if (coinSound != null) {
				coinSound.Play ();
			}
		} else if(other.gameObject.tag == "fire") {
			Debug.Log ("Collision with " + other.gameObject.tag);
			Player.Instance.Health -= 10;
		}
			
		ArrowController sp = other.gameObject.GetComponent<ArrowController> ();

		if (sp != null) {
			sp.Reset ();
		}


	}
		
}
