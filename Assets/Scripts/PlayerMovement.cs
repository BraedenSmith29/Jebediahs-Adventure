using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	public int Speed = 10;
	public int JumpForce = 300;
	public bool Jetpack = false;
	public bool DirectionFacing = true;
	public Rigidbody2D Player;
	private float xvel;
	public Image JetpackMeterImage;
	private float MeterWidth;
	private float MeterHeight;
	private float seconds;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		LeftRight ();
		Jump ();
		MaxVelocity ();
		JetpackMeter ();
		Flip ();
	}

	void LeftRight () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(Vector2.left * Speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(Vector2.right * Speed * Time.deltaTime);
		}
	}

	void Jump () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jetpack = true;
		}
		if (Input.GetKey (KeyCode.Space)) {
			Player.AddForce (new Vector2 (0, 20));
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			Jetpack = false;
		}
	}

	void JetpackMeter () {
		MeterWidth = JetpackMeterImage.transform.localScale.x;
		MeterHeight = JetpackMeterImage.transform.localScale.y;
		if (Jetpack == true) {
			JetpackMeterImage.transform.localScale = new Vector2 (MeterWidth - 0.03f / Time.deltaTime, MeterHeight);
			if (JetpackMeterImage.transform.localScale.x <= 0) {
				JetpackMeterImage.transform.localScale = new Vector2 (0, MeterHeight);
				Jetpack = false;
			}
		}
		if (Jetpack == false) {
			JetpackMeterImage.transform.localScale = new Vector2 (MeterWidth + 0.05f / Time.deltaTime, MeterHeight);
			if (JetpackMeterImage.transform.localScale.x >= 350) {
				JetpackMeterImage.transform.localScale = new Vector2 (350, MeterHeight);
			}
		}
	}

	void Flip () {
		if (Input.mousePosition.x < Camera.main.WorldToViewportPoint (this.transform.position).x * Screen.width && DirectionFacing == true) {
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
			DirectionFacing = false;
		}
		if (Input.mousePosition.x > Camera.main.WorldToViewportPoint (this.transform.position).x * Screen.width && DirectionFacing == false) {
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
			DirectionFacing = true;
		}
	}

	void MaxVelocity () {
		xvel = Player.velocity.x;
		if (Player.velocity.y > 8) {
			Player.velocity = new Vector2 (xvel, 8);
		}
	}
}