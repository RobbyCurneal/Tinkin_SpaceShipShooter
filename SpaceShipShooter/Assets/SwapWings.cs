using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapWings : MonoBehaviour {
    public GameObject[] rWingsArray;
    public GameObject[] lWingsArray;
    public GameObject player;
    public GameObject descriptionText;
    private int arrayIndex;

	void Start () {
        for (int i = 0; i < rWingsArray.Length; i++)
        {
            if (player.GetComponent<Ship_Constructor>().rWing == rWingsArray[i])
            {
                arrayIndex = i;
            }
        }
	}
	
	public void WingSwap()
    {
        arrayIndex++;
        if (arrayIndex >= rWingsArray.Length)
           arrayIndex = 0;
        player.GetComponent<Ship_Constructor>().rWing = rWingsArray[arrayIndex];
        player.GetComponent<Ship_Constructor>().lWing = lWingsArray[arrayIndex];
        player.GetComponent<Ship_Constructor>().rWingChild.GetComponent<SpriteRenderer>().sprite = rWingsArray[arrayIndex].GetComponent<SpriteRenderer>().sprite;
        player.GetComponent<Ship_Constructor>().lWingChild.GetComponent<SpriteRenderer>().sprite = lWingsArray[arrayIndex].GetComponent<SpriteRenderer>().sprite;
        descriptionText.GetComponent<Text>().text = rWingsArray[arrayIndex].GetComponent<Description>().itemDescription;
    }
}