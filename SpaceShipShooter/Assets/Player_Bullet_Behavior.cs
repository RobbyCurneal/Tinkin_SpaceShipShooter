using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet_Behavior : MonoBehaviour {
    public GameObject explosion;
    public int Damage = 50;

	// Use this for initialization
	void Start () {
        Physics2D.IgnoreLayerCollision(8, 13);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<BaddieHealth>() != null)
        collision.collider.GetComponent<BaddieHealth>().Health -= Damage;

        GameObject explosionInstance = Instantiate(explosion, new Vector2(transform.position.x, transform.position.y), transform.rotation) as GameObject;
        Destroy(gameObject);
    }
}
