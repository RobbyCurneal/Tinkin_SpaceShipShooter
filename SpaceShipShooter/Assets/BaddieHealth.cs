using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddieHealth : MonoBehaviour {
    public int Health;
    private GameObject otherCollider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        checkHealth();
	}

    void checkHealth()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
