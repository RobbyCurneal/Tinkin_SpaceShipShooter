using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Movement : MonoBehaviour {

    public int playerSpeed = 25;
    public float moveX;
    public float moveY;
    public Rigidbody2D bullet;
    public int bulletSpeed;
    private Rigidbody2D rigidBody;
    private int counter;
    private float rotation = 0;
    public float rotX = 0;
    public float rotY = 0;
    private FireGuns fireGuns;
    private int fireRate;


    // Use this for initialization
    void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        fireGuns = gameObject.AddComponent(typeof(FireGuns)) as FireGuns;
        initializeFireGuns();
        fireRate = fireGuns.fireRate;
        counter = fireRate;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        playerMove();

        if ((counter == fireRate && Input.GetButton("Fire1")))
        {
            fireGuns.fireGuns();
            counter = 0;
        }
        
        if(counter != fireRate)
        {
            counter++;
        }
	}

    void playerMove()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        
        rigidBody.velocity = new Vector2(moveX * playerSpeed, moveY * playerSpeed);

    }

    void initializeFireGuns()
    {
        FireGuns reference = gameObject.GetComponent<Ship_Constructor>().shipCore.GetComponent<FireGuns>();
        fireGuns.fireRate = reference.fireRate;
        fireGuns.bullet = reference.bullet;
        fireGuns.amountOfBullets = reference.amountOfBullets;
        fireGuns.bulletsXOffset = reference.bulletsXOffset;
        fireGuns.bulletsYOffSet = reference.bulletsYOffSet;
        fireGuns.bulletRotation = reference.bulletRotation;
        fireGuns.bulletSpeed = reference.bulletSpeed;
        fireGuns.bulletSpread = reference.bulletSpread;
    }
}
