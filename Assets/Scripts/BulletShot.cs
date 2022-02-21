using UnityEngine;
using System.Collections;

public class BulletShot : MonoBehaviour {

	public GameObject Bullet;
	public PlayerMovement Flip;
	public AudioSource Gunshot;
	public float seconds = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Shoot ();
	}
	 
	void Shoot () {
		seconds += Time.deltaTime;
		if (Input.GetKey (KeyCode.Mouse0)) {
			if (seconds >= 0.6f) {
				seconds = 0;
				Gunshot.Play ();
				if (Flip.DirectionFacing == false) {
					Vector3 mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10);
					Vector3 lookPos = Camera.main.ScreenToWorldPoint (mousePos);
					lookPos = lookPos - transform.position;
					float angle = Mathf.Atan2 (lookPos.y, lookPos.x) * Mathf.Rad2Deg;
					Instantiate (Bullet, new Vector2 (this.transform.position.x, this.transform.position.y), Quaternion.AngleAxis (angle, Vector3.forward));
				}
				if (Flip.DirectionFacing == true) {
					Vector3 mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10);
					Vector3 lookPos = Camera.main.ScreenToWorldPoint (mousePos);
					lookPos = lookPos - transform.position;
					float angle = Mathf.Atan2 (lookPos.y, lookPos.x) * Mathf.Rad2Deg;
					Instantiate (Bullet, new Vector2 (this.transform.position.x, this.transform.position.y), Quaternion.AngleAxis (angle, Vector3.forward));
				}
			}
		}
	}
}
