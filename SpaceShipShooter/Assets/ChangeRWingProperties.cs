using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRWingProperties : MonoBehaviour {
    public GameObject rWing;
    public float xOffSet;
    public float yOffSet;

	// Use this for initialization
	void Awake () {
        rWing = gameObject.GetComponentInParent<Ship_Constructor>().rWing;
        gameObject.GetComponent<EdgeCollider2D>().points = rWing.GetComponent<EdgeCollider2D>().points;
        gameObject.GetComponent<SpriteRenderer>().sprite = rWing.GetComponent<SpriteRenderer>().sprite;
        transform.position = new Vector2(transform.position.x + rWing.GetComponent<WingOffset>().XOffset, transform.position.y + gameObject.GetComponentInParent<Ship_Constructor>().shipCore.GetComponent<CoreOffset>().YOffset);
    }

    private void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate () {
        
	}
}
