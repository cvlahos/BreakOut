using UnityEngine;
using System.Collections;

public class LoseBox : MonoBehaviour 
{
	public LevelManager levelManager;
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
		//Debug.Log ("Trigger Dectected");
		levelManager.LoseChanceAndReset ();
		
	}

}
