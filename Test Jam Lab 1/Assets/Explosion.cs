using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public GameObject explosion;
	void OncollisionEnter (Collision other){
		if (other.gameObject.tag == "Cubes") {
			Instantiate (explosion, transform.position, transform.rotation);
				Destroy(this.gameObject);
		}
	
	}
}
