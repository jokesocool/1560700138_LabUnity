using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Kadod : MonoBehaviour {
	public Rigidbody rb;
	public GameObject Button;
	public GameObject PlayerDeadPrefab;
	private int count;
	public Text countText;
	public void Jump (){
		rb.velocity = new Vector3(0, 5, 0);
	}
	void Start() {
		rb = GetComponent<Rigidbody>();
		count = 0;
		countText.text = "score : " +count.ToString ();
	}


	void Update(){
		if (rb.velocity.y < 0) {
			lastVelocity = rb.velocity.y;
		}
	}
	float lastVelocity;
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "floor") {
//			float currentvelocity = rb.velocity.y;
			Debug.LogFormat ("currentvelocity = {0}", lastVelocity);
			rb.velocity = new Vector3 (0, -lastVelocity, 0);
		} else if (collision.gameObject.tag == "ceil") {
			Instantiate(PlayerDeadPrefab,this.gameObject.transform.position,Quaternion.identity);
			Destroy (this.gameObject);
			Button.SetActive(true);
		}
	}
	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "cyl") {
			rb.velocity = new Vector3 (0,rb.velocity.y,0);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("score+1")) {
			Debug.Log ("Check");
			count++;
			countText.text = "score : " + count.ToString ();

		} 
		else if (other.gameObject.CompareTag ("score-1")) {
			count--;
			countText.text = "score : " + count.ToString ();
			
		} 
	}

}