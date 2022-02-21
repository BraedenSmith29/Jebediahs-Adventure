using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public GameObject Player;
	public Rigidbody2D PlayerRB;
	public float FallClimbSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TrackPlayer ();
	}

	void TrackPlayer () {
		transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
	}
}
