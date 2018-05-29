using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {
    public float maxHealth;
    public float health;
    public Slider healthBar;
    public GameObject canvas;
    public Button restartButton;
    public Button quitButton;

	// Use this for initialization
	void Start () {
        health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.value = health / maxHealth;
        if(health <= 0)
        {
            Die();
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<damage>() != null)
        {
            health -= collision.collider.GetComponent<damage>().damageVal;
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Button continueButton = Instantiate(restartButton, canvas.transform) as Button;
        Button stopButton = Instantiate(quitButton, canvas.transform) as Button;

    }
}
