using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptingStudent : Student {

    // Use this for initialization
    private new void Start () {
        base.Start();
        animationName = "Interrupting";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
