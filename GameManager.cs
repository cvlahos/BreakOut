using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	static public int score;
	static public int totalBrickCount;
	static public int playerChances = 3;

	public bool detectorsEnabled;


	public LevelManager levelManager;

	public Text scoreText;
	public Text playerChancesText;




	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("brick count-" + totalBrickCount);
		Debug.Log ("player chances-" + playerChances);
	


		scoreText.text = score.ToString ();
		playerChancesText.text = "Player Chances " + playerChances.ToString ();

		//playerChanceText.text = "Chances Left " + playerChances.ToString ();


		if (detectorsEnabled == true)
		{
			WinLevelDetector ();
			LoseGameDetector ();
		}



	}

	void WinLevelDetector()
	{
		if (totalBrickCount == 0) 
		{
			levelManager.LoadNextLevel();
		}
	}


	void LoseGameDetector()
	{
		if (playerChances == 0) 
		{
			levelManager.LoseGame();
		}
	}


}
