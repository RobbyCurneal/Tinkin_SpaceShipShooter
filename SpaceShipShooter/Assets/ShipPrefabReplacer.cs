using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPrefabReplacer : MonoBehaviour {

    public GameObject player;
    public GameObject playerPrefab;

	// Use this for initialization
	public void ReplacePrefab() {
        playerPrefab.GetComponent<Ship_Constructor>().shipCore = player.GetComponent<Ship_Constructor>().shipCore;
        playerPrefab.GetComponent<Ship_Constructor>().lWing = player.GetComponent<Ship_Constructor>().lWing;
        playerPrefab.GetComponent<Ship_Constructor>().rWing = player.GetComponent<Ship_Constructor>().rWing;

    }
}
