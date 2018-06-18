using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Movement : MonoBehaviour {

    public int playerSpeed = 25;
    public float moveX;
    public float moveY;
    private Rigidbody2D rigidBody;
    private int counter;
    private FireGuns fireGuns;
    private int fireRate;
    private otherCoreProperties coreProperties;


    // Use this for initialization
    void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        fireGuns = gameObject.AddComponent(typeof(FireGuns)) as FireGuns;
        initializeFireGuns();
        fireRate = fireGuns.fireRate;
        counter = fireRate;
        coreProperties = gameObject.AddComponent(typeof(otherCoreProperties)) as otherCoreProperties;
        initializeCoreProperties();
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
        fireGuns.alternating = reference.alternating;
        fireGuns.bulletPerFire = reference.bulletPerFire;
    }
    void initializeCoreProperties()
    {
        otherCoreProperties reference = gameObject.GetComponent<Ship_Constructor>().shipCore.GetComponent<otherCoreProperties>();
        coreProperties.speed = reference.speed;
        coreProperties.changesSpeedWhenFiring = reference.changesSpeedWhenFiring;
        coreProperties.firingSpeed = reference.firingSpeed;
    }
}
