using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Constructor : MonoBehaviour {
    public GameObject shipCore;
    public GameObject lWing;
    public GameObject rWing;
    public GameObject lWingChild;
    public GameObject rWingChild;
    private WingAbilityScript wingAbilities;
    public GameObject wingCooldown;

    private FireGuns guns;
    private FireGuns reference;
    private GameObject coreClone;

    // Use this for initialization
    void Start(){
        EdgeCollider2D coreCollider = gameObject.AddComponent(typeof(EdgeCollider2D)) as EdgeCollider2D;
        coreCollider.points = shipCore.GetComponent<EdgeCollider2D>().points;
        gameObject.GetComponent<SpriteRenderer>().sprite = shipCore.GetComponent<SpriteRenderer>().sprite;
        wingAbilities = gameObject.AddComponent(typeof(WingAbilityScript)) as WingAbilityScript;
        initializeWingAbility();

        coreClone = Instantiate(shipCore);
        while(coreClone.GetComponent<FireGuns>() != null)
        {
            initializeGuns();
        }
        Destroy(coreClone);
    }
	
	// Update is called once per frame
	void Update (){
	}

    void initializeWingAbility()
    {
        WingAbilityScript reference = rWing.GetComponent<WingAbilityScript>();
        wingAbilities.leftWing = lWing;
        wingAbilities.rightWing = rWing;
        wingAbilities.createsObject = reference.createsObject;
        wingAbilities.objectCreated = reference.objectCreated;
        wingAbilities.amountOfObjects = reference.amountOfObjects;
        wingAbilities.objectXOffset = reference.objectXOffset;
        wingAbilities.objectYOffset = reference.objectYOffset;
        wingAbilities.createsObjectAtPosition = reference.createsObjectAtPosition;
        wingAbilities.createsObjectInLine = reference.createsObjectInLine;
        wingAbilities.createObjectsInCircle = reference.createObjectsInCircle;
        wingAbilities.deathTrigger = reference.deathTrigger;
        wingAbilities.fireShotsAllAtOnce = reference.fireShotsAllAtOnce;
        wingAbilities.buttonTrigger = reference.buttonTrigger;
        wingAbilities.droneDeathTrigger = reference.droneDeathTrigger;
        wingAbilities.paysHealth = reference.paysHealth;
        wingAbilities.healthPaid = reference.healthPaid;
        wingAbilities.coolsOffGuns = reference.coolsOffGuns;
        wingAbilities.restoresHealth = reference.restoresHealth;
        wingAbilities.healthPrecentageRestored = reference.healthPrecentageRestored;
        wingAbilities.Icon = reference.Icon;
        wingAbilities.cooldown = reference.cooldown;
    }

    void initializeGuns()
    {
        guns = gameObject.AddComponent<FireGuns>();
        reference = coreClone.GetComponent<FireGuns>();
        guns.fireRate = reference.fireRate;
        guns.bullet = reference.bullet;
        guns.amountOfBullets = reference.amountOfBullets;
        guns.bulletsXOffset = reference.bulletsXOffset;
        guns.bulletsYOffSet = reference.bulletsYOffSet;
        guns.bulletRotation = reference.bulletRotation;
        guns.bulletSpeed = reference.bulletSpeed;
        guns.bulletSpread = reference.bulletSpread;
        guns.alternating = reference.alternating;
        guns.bulletPerFire = reference.bulletPerFire;
        guns.counterStart = reference.counterStart;
        guns.burstFireAmount = reference.burstFireAmount;
        guns.burstFireDelay = reference.burstFireDelay;
        guns.bulletXSpawn = reference.bulletXSpawn;
        guns.bulletYSpawn = reference.bulletYSpawn;
        DestroyImmediate(reference);
    }
}
