using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "wall"){
			Destroy (other.gameObject);
		}
	}
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}
}