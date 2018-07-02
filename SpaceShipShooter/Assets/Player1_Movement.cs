using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Movement : MonoBehaviour {

    public int playerSpeed = 25;
    public float moveX;
    public float moveY;
    private Rigidbody2D rigidBody;
    private List<int> counter = new List<int>();
    private List<FireGuns> fireGuns  = new List<FireGuns>();
    private List<int> fireRate = new List<int>();
    private otherCoreProperties coreProperties;
    private int amountOfGuns = 0;


    // Use this for initialization
    void Start() {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        
        coreProperties = gameObject.AddComponent(typeof(otherCoreProperties)) as otherCoreProperties;
        initializeCoreProperties();
    }

    // Update is called once per frame
    void FixedUpdate() {
        playerMove();
	}

    void playerMove()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        rigidBody.velocity = new Vector2(moveX * playerSpeed, moveY * playerSpeed);
        Debug.Log("Horiz: " + moveX + " Vert: " + moveY);

    }

    void initializeCoreProperties()
    {
        otherCoreProperties reference = gameObject.GetComponent<Ship_Constructor>().shipCore.GetComponent<otherCoreProperties>();
        coreProperties.speed = reference.speed;
        coreProperties.changesSpeedWhenFiring = reference.changesSpeedWhenFiring;
        coreProperties.firingSpeed = reference.firingSpeed;
    }
}
