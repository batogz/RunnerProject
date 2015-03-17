using UnityEngine;
using System.Collections;

public class UIScript : MonoBehaviour {
	public bool activeMenu;
	movement player;
	Cameramovement cam;
	GameObject menu;
	float EscapeDown = -2.0f;
	/**
	 * Finds all important game objects and disables the main menu to start the game
	 */
	void Start(){
		player = GameObject.Find ("Character").GetComponent < movement > ();
		cam = GameObject.Find("Main Camera").GetComponent < Cameramovement > ();
		activeMenu = false;

		menu = transform.FindChild ("Menu").gameObject;
		menu.SetActive (false);
	}
	/**
	 * Toggles the menu and keeps track of which state the menu is currently in
	 * so the menu can flip smoothly
	 */
	void Update(){
		if (Input.GetKey("escape") && ((Time.time - EscapeDown) > 0.5f)) {
			activeMenu = !activeMenu;

			player.SetSpeed (!activeMenu);
			cam.SetSpeed(!activeMenu);
			menu.SetActive (activeMenu);
			EscapeDown = Time.time;
		}
	}
	/**
	 * OnGui Summons the menu and it's buttons
	 * 
	 */

	void OnGUI() {
		if (activeMenu) {
			if(GUI.Button (new Rect(860,200, 200,100), "First Level")){
				Application.LoadLevel ("TerrorRun");// loads the first level
			}
			if(GUI.Button (new Rect(860, 300 , 200 ,100), "Second Level")){
				Application.LoadLevel ("brittanyscene"); // loads the second level
			}
			if(GUI.Button (new Rect(860, 400, 200, 100), "Third Level")){
				Application.LoadLevel ("Night Level");// loads the third level
			}
			if(GUI.Button (new Rect (860, 500, 200, 100), "Exit Game")){
				Application.Quit();
			}
			if(GUI.Button (new Rect(860,600, 200,100), "Resume Game")){
				activeMenu = false;
				menu.SetActive(false);
				player.SetSpeed (true);
				cam.SetSpeed (true);
				EscapeDown = Time.time;
			}
		}
	}
}
