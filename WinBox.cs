using UnityEngine;
using System.Collections;

public class WinBox : MonoBehaviour 
{
	//public GameManager gameManager;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnCollisionEnter2D()
	{
		Debug.Log ("Collision Dectected");
	
	}
	
	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger Dectected");
		//gameManager.score = gameManager.score + 1;
		
	}

}
