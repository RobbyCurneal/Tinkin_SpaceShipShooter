using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Behavior : MonoBehaviour {
    public int explosionLength;
    private int counter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        counter++;
        if(counter >= explosionLength)
        {
            Destroy(gameObject);
        }
	}
}
