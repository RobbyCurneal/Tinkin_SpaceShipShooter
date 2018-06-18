using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Sprite Icon;
    public int cooldown;
    public GameObject coolDownIndicator;

    private int deathCooldown;
    private int buttonCooldown;
    private int droneCooldown;

    // Use this for initialization
    void Start () {
        coolDownIndicator = gameObject.GetComponent<Ship_Constructor>().wingCooldown;
        coolDownIndicator.transform.Find("Fill Area").GetComponentInChildren<Image>().sprite = Icon;
        coolDownIndicator.transform.Find("Background").GetComponent<Image>().sprite = Icon;
        if (deathTrigger)
        {
            deathCooldown = cooldown;
        }
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
        if(deathCooldown > 0 && deathCooldown != cooldown)
        {
            deathCooldown++;
            coolDownIndicator.GetComponent<Slider>().value = (float)deathCooldown / cooldown;
        }
        if(deathCooldown == cooldown)
        {
            deathTrigger = true;
        }
	}

    bool IsTriggered()
    {
        if (deathTrigger && gameObject.GetComponent<Player_Health>().health <= 0)
        {
            deathTrigger = !deathTrigger;
            deathCooldown = 1;
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
