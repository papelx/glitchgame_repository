using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timerManager : MonoBehaviour {

	public float Timer;
	public Text timerText;
	public Renderer particleStars;


	public AudioClip loop1;
	public AudioClip loop2;
	public AudioClip loop3;
	public AudioClip loop4;
	public AudioClip loop5;
	public AudioClip loop6;


	public AudioSource audSrc;

	
	private bool loopOK;

	private string loopName;

	public Text winTxt;
	public Button playAgain;
	void Start()
	{
		loopOK = true;
	}

	public void setLoop()
	{

			audSrc.Play();
		
	}

	// Update is called once per frame
	void Update () 
	{
		Timer -= Time.deltaTime;
		timerText.text = Timer.ToString ("Time to build: " + "0");

		Color newColor = new Color (Random.value, Random.value, Random.value, 1.0f);
		//renderer.material.color = newColor;
		particleStars.renderer.material.color = newColor;

	if (Timer <= 0f) {
			winTxt.gameObject.SetActive(true);
			Timer = 0f;
			playAgain.gameObject.SetActive(true);
		}

		if (Timer >= 250f )
		{	
			audSrc.clip = loop1;



		
		}else if(Timer <= 250 && Timer >= 249){
			audSrc.clip = loop2;
			if (!audSrc.isPlaying && audSrc.clip.isReadyToPlay && Timer < 250f)
			{

				audSrc.Play();
		


			}
		}else if(Timer <= 200 &&Timer >= 199f ){
			audSrc.clip = loop3;
			if (!audSrc.isPlaying && audSrc.clip.isReadyToPlay && Timer < 200f)
			{
				
				audSrc.Play();
				
				
				
			}
		}else if(Timer <= 150 && Timer >= 149f){
			audSrc.clip = loop4;
			if (!audSrc.isPlaying && audSrc.clip.isReadyToPlay && Timer < 150f)
			{
				
				audSrc.Play();
				
				
				
			}
		}else if(Timer <= 100 && Timer >= 99f){
			audSrc.clip = loop5;
			if (!audSrc.isPlaying && audSrc.clip.isReadyToPlay && Timer < 100f)
			{
				
				audSrc.Play();
				
				
				
			}
		}else if(Timer <= 60f && Timer >= 59f){
			audSrc.clip = loop6;
			if (!audSrc.isPlaying && audSrc.clip.isReadyToPlay && Timer < 60f)
			{
				
				audSrc.Play();
				
				
				
			}
		}
	}
}
