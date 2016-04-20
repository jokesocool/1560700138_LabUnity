using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameMain : MonoBehaviour {
	public GameObject PlayerDeadPrefab;
	public Rigidbody rb;
	public GameObject Button;
	public GameObject ButtonA;

	private int count;
	private int count1;
	public Text countText;
	public Text countLife;
	// Use this for initialization
	void Start () {
		Button.SetActive(false);
		rb = GetComponent<Rigidbody>();
		count = 1;
		count1 = 0;
		countText.text = "score : " +count1.ToString ();
		countLife.text = "Life : " +count.ToString ();
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "enemy") {
			Instantiate(PlayerDeadPrefab,this.gameObject.transform.position,Quaternion.identity);
			Destroy (this.gameObject);
			count= count - 1;
			countLife.text = "Life : " + count.ToString ();
			Button.SetActive(true);
			ButtonA.SetActive(true);
		}
		else if (collision.gameObject.tag == ("point")) {
			count1= count1 + 100;
			countText.text = "Score : " + count1.ToString ();
			
		} 
	}


}
