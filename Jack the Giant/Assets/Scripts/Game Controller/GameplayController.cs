﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour 
{
	public static GameplayController instance;

	[SerializeField]
	private Text scoreText, coinText, lifeText, gameOverScoreText, gameOverCoinText;

	[SerializeField]
	private GameObject pausePanel, gameOverPanel;

	[SerializeField]
	private GameObject readyButton;

	// Use this for initialization
	void Awake () 
	{
		MakeInstance ();
	}

	void Start()
	{
		Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void MakeInstance () 
	{
		if (instance == null) 
		{
			instance = this;
		}
	}

	public void GameOverShowPanel(int finalScore, int finalCoinScore)
	{
		gameOverPanel.SetActive (true);
		gameOverScoreText.text = finalScore.ToString ();
		gameOverCoinText.text = finalCoinScore.ToString ();
		StartCoroutine (GameOverLoadMainMenu ());
	}

	IEnumerator GameOverLoadMainMenu()
	{
		yield return new WaitForSeconds (3f);
		//SceneManager.LoadScene ("MainMenu");
		SceneFader.instance.LoadLevel("MainMenu");
	}

	public void PlayerDiedRestartTheGame()
	{
		StartCoroutine (PlayerDiedRestart ());
	}

	IEnumerator PlayerDiedRestart()
	{
		yield return new WaitForSeconds (1f);
		//SceneManager.LoadScene ("Gameplay");
		SceneFader.instance.LoadLevel("Gameplay");
	}

	public void SetScore(int score)
	{
		scoreText.text = score.ToString();
	}

	public void SetCoinScore(int coinScore)
	{
		coinText.text = "x" + coinScore;
	}

	public void SetLifeScore(int lifeScore)
	{
		lifeText.text = "x" + lifeScore;
	}

	public void PauseTheGame()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
	}

	public void ResumeGame()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}

	public void QuitGame()
	{
		Time.timeScale = 1f;
		//SceneManager.LoadScene ("MainMenu");
		SceneFader.instance.LoadLevel("MainMenu");

	}

	public void StartTheGame()
	{
		Time.timeScale = 1f;
		readyButton.SetActive (false);
	}




}
