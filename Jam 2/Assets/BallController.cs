using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	public Rigidbody rb;
	public GameObject Button;
	bool readyJump;

	public void Jump (){
		if (readyJump) {
			rb.velocity = new Vector3 (0, 5, 0);
		}
	}
	void Start () {

		rb = GetComponent<Rigidbody>();
	}
	

	void Update () {


	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "box") {
			readyJump = true;
		}
	}
	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "box") {
			readyJump = false;

		}
	}
}
