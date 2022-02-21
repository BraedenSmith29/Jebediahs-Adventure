using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	public GameObject Player;
	public int score = 0;
	public int life = 10;
	public Text points;
	public Text lives;
	private float seconds = 0;
	public GameObject End;
	public Text EndText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ScoreUp ();
		LivesDown ();
	}

	void ScoreUp () {
		points.text = "Enemies Killed: " + score;
	}

	void LivesDown () {
		lives.text = "Lives: " + life;
		if (life <= 0) {
			Destroy (Player.gameObject);
			seconds += Time.deltaTime;
			End.SetActive (true);
			EndText.text = "You Have Died! Your Score Was: " + score;
			if (seconds >= 5 && Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (0);
			}
		}
	}
}
