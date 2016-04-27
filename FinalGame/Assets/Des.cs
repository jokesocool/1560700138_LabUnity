using UnityEngine;
using System.Collections;

public class Des : MonoBehaviour
{
	void OnCollisionEnter(Collider other)
	{
		Destroy(other.gameObject);
	}
}

