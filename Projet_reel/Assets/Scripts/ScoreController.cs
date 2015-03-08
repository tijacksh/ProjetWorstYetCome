using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

	Text text;

	private Vector3 initialPos;
	private Quaternion originalRotation;

	private float lol;
	

	public static int Team1Score, Team2Score;
	// Use this for initialization
	void Awake()
	{
		text = GetComponent <Text> ();
		Team1Score = 1;
		Team2Score = 0;

		initialPos = transform.position;
		originalRotation = transform.rotation;
	}

	void Update ()
	{
		/*
		lol = transform.position.x;

		int caca = Team1Score-1;

		if (lol <= -84.4)
		{
			Team2Score++;
			resetBall();
		}

		else if (lol == 67.3)
		{
			Team1Score = (Team1Score +1) + Team1Score - (caca);
			resetBall();
		}

		else
		{
			Team1Score = Team1Score -1;
		}

		text.text = Team1Score + "       -      " + Team2Score;
		*/

		if (transform.position.x > 670.3f)
		{ 
			//Team1Score++;
			resetBall();
		}

		text.text = Team1Score + "       -      " + Team2Score;
	}

	void resetBall()
	{
		transform.position = initialPos;
		transform.rotation = originalRotation;
	}
}
