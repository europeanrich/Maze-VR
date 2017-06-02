using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofObject;
	public GameObject doorObject;
	private float speed = 300f;
    //Create a variable to store whether or not the key has been collected or not
    public static bool keyCollected = false;
	public static bool playDoorUnlockedSound = true;

	void Update()
	{
		//Debug.Log("Update is called ...Key.cs");
		//Not required, but for fun why not try adding a Key Animation here :)

		// Space.World is used to make key rotate about the world Z axis
		transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);

	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Object.Instantiate(keyPoofObject, transform.position, Quaternion.Euler(270, 0, 0));
        // Call the Unlock() method on the Door
		// Debug.Log("Door.cs is called now ");
		playDoorUnlockedSound = false;
		// Debug.Log("Key.cs keyCollected = " + keyCollected);
		doorObject.GetComponent<Door>().Unlock();

        // Set the Key Collected Variable to true
		keyCollected = true;

		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
    }

}
