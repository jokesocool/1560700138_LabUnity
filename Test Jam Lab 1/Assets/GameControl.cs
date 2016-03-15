using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	public GameObject hazard;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	void Update () {
		
	}
	public void DoPlayAgain(){
		Application.LoadLevel (0);
	
	}
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (4, 0, 0);
				Quaternion spawnRotation = Quaternion.identity;
				GameObject hazardShoot = (GameObject)Instantiate (hazard, spawnPosition, spawnRotation);
				hazardShoot.transform.Rotate (new Vector3 (0, 0, 1), 90);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

}
