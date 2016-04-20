using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public float speedX = -2;
	public float speedY = 0;
	public float speedZ = 0;
	public Rigidbody rb;
	void Start ()
	{
	}
	void Update ()
	{
		rb = GetComponent<Rigidbody>();
		rb.transform.Translate (new Vector3 (speedX, speedY, speedZ) * Time.deltaTime);
	}
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "destroys"){
			Destroy (this.gameObject);
		}
	}
}﻿