using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	public GameObject hazard;
	public Vector3 spawnValues;
	// Use this for initialization
	void Start () {
		SpawnWaves ();
	}
	
	// Update is called once per frame
	void SpawnWaves () {
		Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (hazard, spawnPosition, spawnRotation);
	}
}
