using UnityEngine;
using System.Collections;
/**
 * Randomly switches between any number of preloaded audio sources
 */
public class SoundScript : MonoBehaviour {
	AudioSource[] source;
	
	void Start(){
	
	source = GetComponents<AudioSource>();
	}
	
	void OnTriggerEnter(Collider thing){
		source[Random.Range(0, source.Length)].Play();
	}
}
