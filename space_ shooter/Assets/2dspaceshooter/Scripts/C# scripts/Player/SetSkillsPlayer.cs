using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SetSkillsPlayer : MonoBehaviour
{


	public Rigidbody bulletOne;
	public float skillSpeed;
	public int skillPower;
	public int skillLevel;
	public int skillLevelPlayerActive;
	public List<GameObject> ShooterList = new List<GameObject> ();
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("s")) {
			setSkill ("oneShot");
		}
           

		if (Input.GetKeyDown ("a")) {
			setSkill ("twoShot");
			skillSpeed = 70f;
		}

		if (Input.GetKeyDown ("d")) {
			setSkill ("threeShot");
			skillSpeed = 120f;
		}


	}

	public void setSkill (string skillsName)
	{
		switch (skillsName) {
		case "oneShot":

			ShooterList = new List<GameObject> (GameObject.FindGameObjectsWithTag ("oneBullet"));
			foreach (var shooter in ShooterList) {
				Rigidbody clone;
				clone = Instantiate (bulletOne, shooter.transform.position, shooter.transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection (Vector3.up * skillSpeed);
				skillSpeed = 30f;
			}
			break;

		case "twoShot":

			ShooterList = new List<GameObject> (GameObject.FindGameObjectsWithTag ("twoBullet"));

			foreach (var shooter in ShooterList) {
				Rigidbody clone;
				clone = Instantiate (bulletOne, shooter.transform.position, shooter.transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection (Vector3.up * skillSpeed);
				//skillSpeed = 70f;
				
			}
			break;
			
		case "threeShot":

			ShooterList = new List<GameObject> (GameObject.FindGameObjectsWithTag ("threeBullet"));

			foreach (var shooter in ShooterList) {
				Rigidbody clone;
				clone = Instantiate (bulletOne, shooter.transform.position, shooter.transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection (Vector3.up * skillSpeed);
				//skillSpeed = 120f;

			}
			break;
		}
	}
}
