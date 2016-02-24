using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		if (Input.GetButtonDown("Jump"))
			rb.velocity = new Vector3(0, 5, 0);
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "floor") {
			rb.velocity = new Vector3(0, 5, 0);
		}
	}
}