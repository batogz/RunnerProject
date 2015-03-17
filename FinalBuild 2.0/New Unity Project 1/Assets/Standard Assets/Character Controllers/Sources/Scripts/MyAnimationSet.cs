using UnityEngine;
using System.Collections;

public class AnimationSet {
	
	public Texture[] texture;
	public bool cyclic;
	
	// Use this for initialization
	
	public AnimationSet (Texture [] tex) {
		texture = tex;
		cyclic = true;
	}
	
	public AnimationSet (Texture [] tex, bool cyc) {
		texture = tex;
		cyclic = cyc;
	}
}
