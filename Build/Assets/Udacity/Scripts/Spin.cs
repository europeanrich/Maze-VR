using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Spin : MonoBehaviour {

	private float speed = 100f;

	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
	}
}
