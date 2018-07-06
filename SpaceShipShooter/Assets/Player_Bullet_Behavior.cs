using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet_Behavior : MonoBehaviour {
    public GameObject explosion;
    public bool explodes;
    public int Damage = 50;
    public int speed;
    private GameObject explosionInstance;
    public bool destroyNow;

	// Use this for initialization
	void Start () {
        Physics2D.IgnoreLayerCollision(8, 13);
        if (gameObject.GetComponent<Rigidbody2D>().velocity == new Vector2(0, 0))
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<BaddieHealth>() != null)
        collision.collider.GetComponent<BaddieHealth>().Health -= Damage;
        Damage = 0;

        if (collision.collider.GetComponent<BaddieHealth>().Health < 0)
            Damage -= collision.collider.GetComponent<BaddieHealth>().Health;

        if(explodes)
            explosionInstance = Instantiate(explosion, new Vector2(transform.position.x, transform.position.y), transform.rotation) as GameObject;

        if(Damage <= 0 || destroyNow)
            Destroy(gameObject);
    }
}
