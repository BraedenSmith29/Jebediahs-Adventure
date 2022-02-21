using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move () {
		transform.Translate (Vector2.right * 15 * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (!other.CompareTag ("Player") && !other.CompareTag ("Enemy")) {
			Destroy (this.gameObject);
		}
	}
}
