using System.Collections;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

	public float speed = 5f;
	public float rotationSpeed = 10f;

	Vector3 movement;
	Transform playerTransform;
	Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {
		playerTransform = GetComponent<Transform> ();
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalAxisOffset = Input.GetAxis ("Horizontal");
		float verticalAxisOffset = Input.GetAxis ("Vertical");

		Move (horizontalAxisOffset, verticalAxisOffset);
		Rotate (horizontalAxisOffset);
	}

	void Move(float horizontalAxisOffset, float verticalAxisOffset) {
		movement.Set (horizontalAxisOffset, 0f, verticalAxisOffset);

		movement = movement.normalized * speed * Time.deltaTime;

		playerRigidbody.MovePosition (playerTransform.position + movement);
	}

	void Rotate(float horizontalAxisOffset) {
		playerTransform.Rotate (0f, horizontalAxisOffset * rotationSpeed, 0f);
	}
}
