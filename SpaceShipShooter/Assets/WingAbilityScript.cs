using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingAbilityScript : MonoBehaviour {
    public GameObject leftWing;
    public GameObject rightWing;
    public bool createsObject;
    public Rigidbody2D objectCreated;
    public int amountOfObjects;
    public int objectXOffset;
    public int objectYOffset;
    public bool createsObjectAtPosition;
    public bool createsObjectInLine;
    public bool createObjectsInCircle;
    public bool deathTrigger;
    public bool fireShotsAllAtOnce;
    public bool buttonTrigger;
    public bool droneDeathTrigger;
    public bool paysHealth;
    public int healthPaid;
    public bool coolsOffGuns;
    public bool restoresHealth;
    public int healthPrecentageRestored;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (IsTriggered())
        {
            if (createsObject)
            {

            }
            if (restoresHealth)
            {
                Debug.Log("Restored Health");
                gameObject.GetComponent<Player_Health>().health += gameObject.GetComponent<Player_Health>().maxHealth / (100 / healthPrecentageRestored);
            }

        }
	}

    bool IsTriggered()
    {
        if (deathTrigger && gameObject.GetComponent<Player_Health>().health <= 0)
        {
            deathTrigger = !deathTrigger;
            Debug.Log("Triggered");
            return true;
        }
        if(!deathTrigger && gameObject.GetComponent<Player_Health>().health <= 0)
            gameObject.GetComponent<Player_Health>().Die();
        if (buttonTrigger && Input.GetButton("fireSubweapon"))
            return true;

        return false;
    }
}
