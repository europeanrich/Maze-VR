using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update()

    private bool locked = true;
    private bool openDoor = false;
	public float fullyRaised = 7;
	public AudioClip[] soundFiles;
	public AudioSource soundSource;



    void Update() 
    {
		// Debug.Log("Update is called ...Door.cs");
        // If the door is unlocked and it is not fully raised
		// Animate the door raising up

		if (!locked && transform.position.y < fullyRaised)
        {
        		
	    		transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
				// Debug.Log("Door is unlocked!");
		}
	}


    public void Unlock()
    {
		//Debug.Log("Unlock() is called");
        // You'll need to set "locked" to false here
		
		//Debug.Log("(Door.cs Key.keyCollected value = " + Key.keyCollected);
		//Debug.Log("Door is unlocked");
		if (Key.keyCollected)
		{
			locked = false;
			//Debug.Log("Locked value = " + locked);
			soundSource.clip = soundFiles [1];
			soundSource.Play();
    	}

		else if (Key.playDoorUnlockedSound)
		{
			//locked = true;
			//Debug.Log("Door is locked:" + locked);
			soundSource.clip = soundFiles [0];
			soundSource.Play();
		}
	}
}
