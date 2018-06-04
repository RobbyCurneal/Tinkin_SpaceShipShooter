using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursedLegion_Wing2_Script : MonoBehaviour {
    public GameObject leftWing;
    public Rigidbody2D orb;
    public float orbVelocity;
    public int coolDown;
    public int xOffSet;
    public int yOffSet;

    private bool canFireRight;
    private bool canFireLeft;
    private bool firingRight = true;
    private int rCooldown;
    private int lCooldown;

	// Use this for initialization
	void Start () {
        float leftX = leftWing.transform.position.x;
        float leftY = leftWing.transform.position.y;
        float rightX = transform.position.x;
        float rightY = transform.position.y;
        rCooldown = coolDown;
        lCooldown = coolDown;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (rCooldown == coolDown)
            canFireRight = true;
        else
            rCooldown++;
        if (lCooldown == coolDown)
            canFireLeft = true;
        else
            lCooldown++;

        if (Input.GetButtonDown("FireSubweapon"))
        {
            if (firingRight)
            {
                if (canFireRight)
                {

                }
            }

            if (!firingRight)
            {
                if (canFireLeft)
                {

                }
            }
        }

	}
}
