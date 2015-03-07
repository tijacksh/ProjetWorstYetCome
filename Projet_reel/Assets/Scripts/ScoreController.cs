using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

	Text text;

	public static Transform ball;

	public static int PlayerScore;
	// Use this for initialization
	void Awake()
	{
		text = GetComponent <Text> ();
		PlayerScore = 0;
	}

	void Update ()
	{
		IncreasePlayerScore ();
	}

	void IncreasePlayerScore()
	{
		if ((ball.position.z > -4.85) && (ball.position.z < 4.8) && ball.position.x < -5) {
			PlayerScore = PlayerScore + 1;	
			ball.rigidbody.position = new Vector3(0, 0.6F, 0);
		}
		text.text = PlayerScore + "       -";
	}
}
