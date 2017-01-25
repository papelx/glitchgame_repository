using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class weaponController : MonoBehaviour {


	public Rigidbody projectile;



	void Update()
	{
		if(Input.GetKeyDown("s"))
			weaponSelect("oneShoot");

	}


	// Update is called once per frame
 public void weaponSelect (string weapon)
	{
		switch (weapon) {
		
		case "oneShoot":



			break;
		}
	
	}
}
