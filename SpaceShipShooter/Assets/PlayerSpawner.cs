using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpawner : MonoBehaviour {

    public GameObject player;
    public Slider healthBar;
    public GameObject canvas;
    public GameObject wingCooldown;
    public bool disableUserInput;
    public GameObject startButton;
    public GameObject wingSwapButton;

    private GameObject spawnedPlayer;

    // Use this for initialization
    private void Awake()
    {
        spawnedPlayer = Instantiate(player);
        spawnedPlayer.GetComponent<Player_Health>().healthBar = healthBar;
        spawnedPlayer.GetComponent<Player_Health>().canvas = canvas;
        spawnedPlayer.GetComponent<Ship_Constructor>().wingCooldown = wingCooldown;

        if (disableUserInput)
        {
            Destroy(spawnedPlayer.GetComponent<Player1_Movement>());
            while(spawnedPlayer.GetComponent<FireGuns>() != null)
            {
                Destroy(spawnedPlayer.GetComponent<FireGuns>());
            }
        }

        startButton.GetComponent<ShipPrefabReplacer>().player = spawnedPlayer;
        wingSwapButton.GetComponent<SwapWings>().player = spawnedPlayer;

        Destroy(gameObject);

    }
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
