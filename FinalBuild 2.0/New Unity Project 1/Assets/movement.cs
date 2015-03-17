using UnityEngine;
using System.Collections;
/**
 * Handles character movement
 * 
 * Constants: SPEED
 */
public class movement : MonoBehaviour {
	private float SPEED = 1500.0f;

	
	// Use this for initialization
	void Start () {
		Time.timeScale = 1.0f;
		rigidbody.velocity = Vector3.forward * SPEED * Time.deltaTime;
	}

	public void SetSpeed (bool isMoving) {
		if (isMoving)
			rigidbody.velocity = Vector3.forward * SPEED * Time.deltaTime;
		else
			rigidbody.velocity = Vector3.zero;
	}

	// Update is called once per frame
	void Update () {
		Vector3 where = transform.position;
		where.x = Input.GetAxis("Horizontal")*4;
		transform.position = where;	
	}
}
