using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLWingProperties : MonoBehaviour {
    public GameObject lWing;

	// Use this for initialization
	void Awake () {
        lWing = gameObject.GetComponentInParent<Ship_Constructor>().lWing;
        gameObject.GetComponent<SpriteRenderer>().sprite = lWing.GetComponent<SpriteRenderer>().sprite;
        gameObject.GetComponent<EdgeCollider2D>().points = lWing.GetComponent<EdgeCollider2D>().points;
        transform.position = new Vector2(transform.position.x + lWing.GetComponent<WingOffset>().XOffset, transform.position.y + gameObject.GetComponentInParent<Ship_Constructor>().shipCore.GetComponent<CoreOffset>().YOffset);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with wing");
    }
}
