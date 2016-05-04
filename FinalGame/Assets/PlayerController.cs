using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {
	public float speed;
	public float tilt;

	public GameObject Button;
	public GameObject ButtonA;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	private int count;
	private int count1;
	public Text countBullet;
	public Text countScore;

	public GameObject PlayerDeadPrefab;
	// Use this for initialization
	void Start () {
		count = 0;
		count1 = 10;
		countBullet.text = "Bullet : " +count1.ToString ();
		countScore.text = "Score : " +count.ToString ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			count1 = count1 - 1;
			countBullet.text = "Bullet : " + count1.ToString ();

		
		}
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "wall"){
			Instantiate(PlayerDeadPrefab,this.gameObject.transform.position,Quaternion.identity);
			Destroy (this.gameObject);
			count = count + 100;
			countScore.text = "Score : " +count.ToString ();
			Button.SetActive(true);
		}
	}
}
