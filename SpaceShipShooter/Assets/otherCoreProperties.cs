using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherCoreProperties : MonoBehaviour {
    public int speed;
    public bool changesSpeedWhenFiring;
    public int firingSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (changesSpeedWhenFiring && Input.GetButton("Fire1"))
            gameObject.GetComponent<Player1_Movement>().playerSpeed = firingSpeed;
        else
            if (gameObject.GetComponent<Player1_Movement>().playerSpeed < speed)
        {
            gameObject.GetComponent<Player1_Movement>().playerSpeed += 1;
        }
            

	}
}
