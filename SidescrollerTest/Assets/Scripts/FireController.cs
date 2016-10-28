using UnityEngine;
using System.Collections;

public class FireController : MonoBehaviour {


	[SerializeField]
	public float speed;

	private Transform _transform;
	private Vector2 _currentPosition;

	private float minX = -4f;
	private float maxX = -4f;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -6.9) {
			Reset ();
		}
	}

	public void Reset(){
		float xPos = Random.Range(minX, maxX);
		_currentPosition = new Vector2 (2.06f, xPos);
		_transform.position = _currentPosition;
	}

}
