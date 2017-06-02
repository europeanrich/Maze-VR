using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    private float speed = 100;
    public GameObject coinPoofObject;
    public static int counter = 0;
	// Note to self... you must explicitly assign zero to score when level is reset.
	public Text countText;

	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
	}


	/*
	public void OnCoinSelected() {
		//gameObject.transform.Rotate(Vector3.up, speed * 50 * Time.deltaTime, Space.World);
		//gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
		Debug.Log("coin selected");
	}
	*/


    public void OnCoinClicked() {
    	
    	// Debug.Log("The Coin is pointed at");

        // Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		Object.Instantiate(coinPoofObject, transform.position, Quaternion.Euler(270, 0, 0));
		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);

		// Keep score of number of coins collected
		counter ++;
		// Debug.Log("Counter = " + counter);
		if (counter == 1){
			countText.text = counter.ToString () + " coin found" ;
			}
		else {
			countText.text = counter.ToString () + " coins found" ;
		}
    }
}
