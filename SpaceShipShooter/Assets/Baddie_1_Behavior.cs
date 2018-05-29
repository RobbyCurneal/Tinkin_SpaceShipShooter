using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baddie_1_Behavior : MonoBehaviour
{
    public int shipSpeed = 15;
    public int fire_rate = 60;
    public int bulletSpeed = 25;
    public Rigidbody2D bullet;
    private Rigidbody2D rigidBody;
    private int counter = 0;


    // Use this for initialization
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(0f, -shipSpeed);
        counter += 1;

        fireGuns();
    }

    void fireGuns()
    {
        if (counter == fire_rate)
        {
            Rigidbody2D bulletInstance1 = Instantiate(bullet, new Vector2(transform.position.x - 0.4f, transform.position.y - 1), transform.rotation) as Rigidbody2D;
            Rigidbody2D bulletInstance2 = Instantiate(bullet, new Vector2(transform.position.x + 0.4f, transform.position.y - 1), transform.rotation) as Rigidbody2D;

            bulletInstance1.velocity = new Vector2(0, -bulletSpeed);
            bulletInstance2.velocity = new Vector2(0, -bulletSpeed);

            Physics2D.IgnoreCollision(bulletInstance1.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            Physics2D.IgnoreCollision(bulletInstance2.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            Physics2D.IgnoreLayerCollision(9, 10);

            counter = 0;
        }
    }
}
