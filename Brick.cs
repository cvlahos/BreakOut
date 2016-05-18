using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		GameManager.totalBrickCount++;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter2D()
	{
		//Debug.Log ("Collision Dectected");

		GameManager.score++;
		//gameManager.score = gameManager.score + 1;
		GameManager.totalBrickCount--;
		Destroy (gameObject);
		
	}
	
	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger Dectected");
		//gameManager.score = gameManager.score + 1;
		
	}


}
