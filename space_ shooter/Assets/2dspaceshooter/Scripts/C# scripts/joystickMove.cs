using UnityEngine;
using System.Collections;
using XInputDotNetPure;

public class joystickMove : MonoBehaviour {




	public float testA;
	public float testB;
	public float testC;
	public float testD;
	
	public float speed = 0;
	public float rotationSpeed = 0;
	void Update() {
		if (Input.GetKey("joystick button 2")) 
		{
			XInputDotNetPure.GamePad.SetVibration(0, rotationSpeed, speed); 
			print("asdasd");
			XInputDotNetPure.GamePad.SetVibration(0,testA,testB);   
		}
		
		
		if (Input.GetKey("joystick 1 button 0")) {
		}
		
	
		if (Input.GetKey("joystick 2 button 0")) {
		}



	}
}
