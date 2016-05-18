using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{
	public GameManager gameManager;

	public void PlayGame()

	{

		GameManager.playerChances = 3;
		GameManager.totalBrickCount = 0;
		GameManager.score = 0;
		Application.LoadLevel("Game");
	}

	public void LoseGame()
		
	{
		//gameManager.WinDetectorEnabled = false;
		Application.LoadLevel("Lose");
	}

	public void WinGame()
		
	{
		Application.LoadLevel("Win");
	}

	public void LoseChanceAndReset()
	{
		gameManager.detectorsEnabled = false;
		GameManager.totalBrickCount = 0;
		GameManager.playerChances--;
		Application.LoadLevel (Application.loadedLevel);
	}

	public void LoadNextLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}

}
