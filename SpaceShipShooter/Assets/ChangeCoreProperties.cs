using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCoreProperties : MonoBehaviour {
    private GameObject shipCore;
    public GameObject parentObject;

    // Use this for initialization
    void Awake () {
        shipCore = gameObject.GetComponentInParent<Ship_Constructor>().shipCore;
        gameObject.GetComponent<SpriteRenderer>().sprite = shipCore.GetComponent<SpriteRenderer>().sprite;
        gameObject.GetComponent<EdgeCollider2D>().points = shipCore.GetComponent<EdgeCollider2D>().points;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = parentObject.transform.position;
    }
}
