using UnityEngine;
using System.Collections;
public class Control : MonoBehaviour {
	public GameObject PlayerDeadPrefab;
	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "wall") {
			Instantiate(PlayerDeadPrefab,this.gameObject.transform.position,Quaternion.identity);
			Destroy (this.gameObject);
		}
	}
}