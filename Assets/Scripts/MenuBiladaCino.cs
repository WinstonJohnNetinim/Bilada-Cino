﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuBiladaCino : MonoBehaviour {
	
	public void Play()
	{
		SceneManager.LoadScene ("Game");
	}

	public void Credits()
	{
		SceneManager.LoadScene ("Credits");
	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void BackToMenu()
	{
		SceneManager.LoadScene ("Menu");
	}
}
