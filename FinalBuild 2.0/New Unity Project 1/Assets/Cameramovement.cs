using UnityEngine;
using System.Collections;
/**
 * Handles camera movement
 * 
 * Constants: SPEED
 */
public class Cameramovement : MonoBehaviour {
	float SPEED = 1500.0f;

	// Use this for initialization
	void Start () {
		rigidbody.velocity = Vector3.forward * SPEED * Time.deltaTime;
	}

	public void SetSpeed (bool active) {
		if (active)
			rigidbody.velocity = Vector3.forward * SPEED * Time.deltaTime;
		else
			rigidbody.velocity = Vector3.zero;
	}

	// Update is called once per frame
	void Update () {
	}
}
