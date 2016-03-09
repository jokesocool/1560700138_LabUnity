using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	float speedX = 0;
	float speedY = 1;
	float speedZ = 0;
	public Rigidbody rb;

	public GameObject hazard;
	public Vector3 spawnValues;

	// Use this for initialization
	void Start () {
		SpawnWaves ();
	}
	
	// Update is called once per frame
	void Update () {
		rb = GetComponent<Rigidbody> ();
		transform.Translate (new Vector3 (speedX, speedY, speedZ) * Time.deltaTime);
	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Wall") {
			Destroy (this.gameObject);
		}
	}
	void SpawnWaves(){
		Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (hazard, spawnPosition, spawnRotation);
	}
}
