using System.Collections;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

	public float movementSpeed = 5f;
	public float rotationSpeed = 5f;

	Vector3 movementDirection = Vector3.zero;
	Transform playerTransform;
	Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {
		playerTransform = GetComponent<Transform> ();
		playerRigidbody = GetComponent<Rigidbody> ();
		GetComponent<Renderer>().material.color = Color.blue;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalAxisOffset = Input.GetAxis ("Horizontal");
		float verticalAxisOffset = Input.GetAxis ("Vertical");

		Move (verticalAxisOffset);
		Rotate (horizontalAxisOffset);
	}

	void Move(float verticalAxisOffset) {
		movementDirection.Set (0f, 0f, verticalAxisOffset);

		movementDirection = movementDirection.normalized * movementSpeed * Time.deltaTime;

		playerRigidbody.MovePosition (playerTransform.position + movementDirection);
	}

	void Rotate(float horizontalAxisOffset) {
		playerTransform.Rotate (0f, horizontalAxisOffset * rotationSpeed, 0f);
	}
}
