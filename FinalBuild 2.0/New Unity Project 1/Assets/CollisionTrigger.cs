using UnityEngine;
using System.Collections;

public class CollisionTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Character") {
						Time.timeScale = 0.0f;
						Application.LoadLevel (Application.loadedLevel);
						Time.timeScale = 1.0f;
				}
	}
}
