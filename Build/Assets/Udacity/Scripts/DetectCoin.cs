using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCoin : MonoBehaviour {
	
	void FixedUpdate() 
    {
		// Get layer mask name, bitshift it to create layer mask and store value as an int
		int raycastLayerMask = (1 << LayerMask.NameToLayer("Clickable objects")); 

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast(transform.position, fwd, 100, raycastLayerMask)) 
		Debug.Log("The coin has been detected");
    }
}
