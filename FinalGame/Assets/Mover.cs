using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;
	
	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
		Physics.gravity = new Vector3(0, -5.0F, 0);
	}
}
