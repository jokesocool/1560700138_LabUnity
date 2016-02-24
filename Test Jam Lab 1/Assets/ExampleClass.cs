using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		if (Input.GetButtonDown("Jump"))
			rb.velocity = new Vector3(0, 4, 0);
		
	}
}