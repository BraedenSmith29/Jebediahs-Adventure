using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

	public GameObject Player;
	private Vector2 PlayerPlace;
	private float seconds = 0;
	private bool Go = false;
	public GameObject Gamemaster;
	public Score score1;

	// Use this for initialization
	void Start () {
		score1 = Gamemaster.GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move () {
		if (Go == false) {
			seconds += Time.deltaTime;
			if (seconds > 5) {
				Go = true;
			}
		}
		if (Go == true) {
			PlayerPlace = Player.transform.position;
			transform.LookAt (PlayerPlace);
			transform.Rotate (new Vector2 (0, 90));
			transform.Translate (Vector2.left * 6 * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag("Player")) {
			transform.position = new Vector2 (Random.Range (1129, 1204), Random.Range (734, 768));
			score1.life--;
		}
		if (other.CompareTag("Bullet")) {
			Destroy (other.gameObject);
			seconds = 3;
			Go = false;
			transform.position = new Vector2 (Random.Range (1129, 1204), Random.Range (734, 768));
			score1.score++;
		}
	}
}