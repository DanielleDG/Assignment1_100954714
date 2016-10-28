using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {


	[SerializeField]
	public float speed;

	private Transform _transform;
	private Vector2 _currentPosition;

	private float minX = -9f;
	private float maxX = 9f;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (0, speed);
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -5.3) {
			Reset ();
		}
	}

	public void Reset(){
		float xPos = Random.Range(minX, maxX);
		_currentPosition = new Vector2 (xPos, 5.3f);
		_transform.position = _currentPosition;
	}


	}

