using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
 * Animation Controlled for 2D Game mode in Unity.  Sprite images are placed in a folder
 * for the animation controller in question.  Because Resources.Load is being used, these
 * assets must be place in the Resources folder.
 * 
 * Private		Description
 * 
 * action		List of AnimationSet objects this AnimationController will work with
 * current		Current AnimationSet being displayed
 * 
 * Public		Description
 * 
 * index		Changed if you want to start the animation at some specific frame
 * rotation		Images per second you want the animation to run at
 * setName		Array of texture names to be used to create the animation sets
 * setSize		Array of integers.  Each is the length of the Animations set with the name corresponding
 */

public class MyAnimationController : MonoBehaviour {
	private List<AnimationSet> action;
	private AnimationSet current;
	
	public float index;
	public float rotation;
	public string[] setName = new string[]{"running"};
	public int[] setSize = new int[]{5};
	public bool[] cyclic = new bool[]{true};
	
/**
 * Used to initialize this AnimationController script
 */
	
	void Start () {
		index = 0.0f;
		current = null;
		action = new List<AnimationSet>();
		
		AddSet ("running", 5, true);
	}
	
/**
 * Adds a new AnimationSet to the list of AnimationSet objects
 * 
 * Parameter	Description
 * 
 * name			Name of the portion of the file name up to the numeric portion.  Include folders, too
 * length		Number of images in the animation set
 */
	
	public void AddSet (string name, int length, bool isCyclic) {
		Texture []texture = new Texture[length];
		
		Debug.Log ("Loading " + name);
		
		for (int i=1;i <= length;i++) {
			string texName = name + i + "t";
			texture[i-1] = (Texture)Resources.Load("Textures/" + texName, typeof(Texture)); 
			Debug.Log (texName + " " + texture[i-1].name);
		}
	
		AnimationSet aSet = new AnimationSet (texture, isCyclic);
		action.Add (aSet);
		
		if (current == null)
			current = aSet;
	}
	
/**
 * Changes the current AnimationSet.  Note: This does not check if you exceed the List.
 * 
 * Parameter	Description
 * 
 * which		Index of the AnimationSet desired (0 .. size-1)
 */
	public void SetAction (int which) {
		current = action[which];
	}
	
/**
 * Updates the texture to animate the object
 */
	void Update () {
		index += rotation * Time.deltaTime;
		if (index >= current.texture.Length)
			if (current.cyclic)
				index -= current.texture.Length;
			else
				index -= current.texture.Length - 1.0f;
		
		renderer.material.SetTexture("_MainTex", current.texture[(int)index]);
	}
}
