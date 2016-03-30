using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BallController : MonoBehaviour {
	public Rigidbody rb;
	public GameObject Button;
	public Button btnGameOver;
	bool readyJump;
	public int count = 0;

	public void Jump (){
		if (readyJump || count < 2) {
			rb.velocity = new Vector3 (0, 5, 0);
			count++;
		}
	}
	void Start () {

		rb = GetComponent<Rigidbody>();
		btnGameOver.gameObject.SetActive (false);
	}
	

	void Update () {


	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "box") {
			readyJump = true;
			count = 0;
		}
	}
	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "box") {
			readyJump = false;

		}
	}
}
