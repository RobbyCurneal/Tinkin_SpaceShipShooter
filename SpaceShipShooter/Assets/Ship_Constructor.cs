using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Constructor : MonoBehaviour {
    public GameObject shipCore;
    public GameObject lWing;
    public GameObject rWing;
    public GameObject coreChild;
    public GameObject lWingChild;
    public GameObject rWingChild;

    // Use this for initialization
    void Start(){
        EdgeCollider2D coreCollider = gameObject.AddComponent(typeof(EdgeCollider2D)) as EdgeCollider2D;
        coreCollider.points = shipCore.GetComponent<EdgeCollider2D>().points;
        gameObject.GetComponent<SpriteRenderer>().sprite = shipCore.GetComponent<SpriteRenderer>().sprite;

        
    }
	
	// Update is called once per frame
	void Update (){
	}
}
