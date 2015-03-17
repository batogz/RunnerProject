using UnityEngine;
using System.Collections;
/**
 * This script handles the dead tree falling towards the
 * lefthand side as an obstacle for the player
 * 
 * Constants: Torque
 * variables: hitTrigger
 */
public class TreeFallin : MonoBehaviour {

	float TORQUE = 10.0f;
	bool hitTrigger;
	GameObject deadTree;
	void Start(){
		hitTrigger = false;
		deadTree = transform.parent.FindChild("DeadTree").gameObject;
		deadTree.rigidbody.useGravity = false;
		Debug.Log (deadTree.name);
	}
	// Use this for initialization
	void OnTriggerEnter (Collider collider) {
		hitTrigger = true;
	
	}
	
	void FixedUpdate (){
		if (hitTrigger) {
			deadTree.rigidbody.useGravity = true;
			deadTree.rigidbody.AddTorque (Vector3.forward * TORQUE);
			}
	}

}
