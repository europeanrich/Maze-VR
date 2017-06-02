using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
        SceneManager.LoadScene("Maze");

        //reset key
        Key.keyCollected = false;

        //reset counter
		Coin.counter = 0;

		//reset play door unlocked sound
		Key.playDoorUnlockedSound = true;

	}
}