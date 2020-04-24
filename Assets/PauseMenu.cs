using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UCL.COMPGV07;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	//public GameObject fps;


	// Update is called once per frame
	public void Update () {

		if(Input.GetKeyDown(KeyCode.Q))
			{
			if (GameIsPaused) {
				Resume();
			}
			else {
				
				Pause ();
			}
			}
		
	}

	public void Resume(){
				pauseMenuUI.SetActive (false);
		//fps.SetActive (true);
				Time.timeScale = 1f;
				GameIsPaused = false;

	}
	public void quit()
	{
		Application.Quit ();
		Program trial = new Program ();
		//trial.Main2 ();

	}
	public void Pause(){
		pauseMenuUI.SetActive (true);
		//fps.SetActive (false);

		Time.timeScale = 0f;
		GameIsPaused = true;

	}
	public void metrics()
	{
		Program trial = new Program ();
		trial.Main2();

	}


}
