using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Baddie_1 : MonoBehaviour {
    public Rigidbody2D baddie;
    public int spawnrate;
    public GameObject counter;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        spawnBaddie();
    }

    void spawnBaddie()
    {
        if (counter.GetComponent<Counter>().counter % spawnrate == 0)
        {
            Rigidbody2D baddieInstance = Instantiate(baddie, transform.position, transform.rotation) as Rigidbody2D;
            baddieInstance.velocity = new Vector2(transform.position.x, transform.position.y);
        }
    }
}
