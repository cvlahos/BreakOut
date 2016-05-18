using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{
	public Ball ball;
	public float paddleSpeed;
	bool isBallLaunched;

	float paddleMovingUpAndDown;
	public float rightBounds;
	public float leftBounds;



	// Use this for initialization
	void Start () 
	{

		isBallLaunched = false;

	}
	
	// Update is called once per frame
	void Update () 
	{

		paddleMovingUpAndDown = Mathf.Clamp (transform.position.x,leftBounds,rightBounds);
		
		transform.position = new Vector3 (paddleMovingUpAndDown,transform.position.y,transform.position.z);
		
		
		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			transform.position += new Vector3(paddleSpeed * Time.deltaTime,0,0); 	
		}
		
		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			transform.position -= new Vector3(paddleSpeed * Time.deltaTime,0,0);
		}
		
		if (Input.GetKeyDown(KeyCode.Space) && isBallLaunched == false) 
			
		{
			ball.LauchBall ();
			isBallLaunched = true;
		}


	}
}
