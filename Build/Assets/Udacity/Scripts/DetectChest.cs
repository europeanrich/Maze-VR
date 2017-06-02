using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectChest : MonoBehaviour {

	public Animator OpenChest;
	public bool isOpen = false;


	void FixedUpdate() 
    {
		// Debug.Log("Chest is closed");
		int raycastLayerMask = (1 << LayerMask.NameToLayer("Chest"));

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast(transform.position, fwd, 10, raycastLayerMask)) {
           // print("The chest is selected!");
           	OpenChest.SetBool ("isOpen", true);
			Camera.main.gameObject.GetComponent<AudioSource>().enabled = false;
			}
    }

}