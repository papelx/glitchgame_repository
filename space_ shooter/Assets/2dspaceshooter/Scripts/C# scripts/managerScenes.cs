using UnityEngine;
using System.Collections;

public class managerScenes : MonoBehaviour {


	

	void Update () 
	{
		getAxis();
		getButton();

		if (Input.GetKey (KeyCode.Return))
		{
			loadGame();
		}
		
		
	}
	
	/// <summary>
	/// Get Axis data of the joysick
	/// </summary>
	void getAxis()
	{

	}
	/// <summary>
	/// get the button data of the joystick
	/// </summary>
	void getButton()
	{
		if(Input.GetButton("joystick button 2"))
			Application.LoadLevel("game");
		
	}
		
	public void loadGame()
	{
		Application.LoadLevel("game");
	}
	



}
