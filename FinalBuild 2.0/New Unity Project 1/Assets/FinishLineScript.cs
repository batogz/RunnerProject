using UnityEngine;
using System.Collections;
/**
 * This function ends the game at the finish level
 * Bugs: Currently the switch statement doesn't trigger the random level
 * swapping
 */
public class FinishLineScript : MonoBehaviour {
	void Start(){
		Time.timeScale = 1.0f;
	}
	void OnTriggerEnter() {

		//Time.timeScale = 0.0f;
		int caseSwitch = Random.Range(0,2);
		switch (caseSwitch)
		{
		case 1:
			Application.LoadLevel("TerrorRun");

			break;
		case 2:
			Application.LoadLevel("brittanyscene");
			break;
		case 3:
			Application.LoadLevel("Night Level");
			break;
		}

	}
}
