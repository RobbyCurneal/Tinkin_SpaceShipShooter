using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baddie_1_Bullet_Behavior : MonoBehaviour {
    public GameObject explosion;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        GameObject explosionInstance = Instantiate(explosion, new Vector2 (transform.position.x, transform.position.y - 0.3f), transform.rotation) as GameObject;
        Destroy(gameObject);
    }
}
