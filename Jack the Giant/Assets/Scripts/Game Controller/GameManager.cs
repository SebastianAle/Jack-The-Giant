﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour 
{

	public static GameManager instance;

	[HideInInspector]
	public bool gameStartedFromMainMenu, gameRestartedAfterPlayerDied;

	[HideInInspector]
	public int score, coinScore, lifeScore;

	// Use this for initialization
	void Awake () 
	{
		MakeSingleton ();
	}

	void Start()
	{
		InitializeVariables ();
	}

	void OnLevelWasLoaded()
	{
		if (SceneManager.GetActiveScene ().name == "Gameplay") 
		{
			if (gameRestartedAfterPlayerDied) 
			{
				GameplayController.instance.SetScore (score);
				GameplayController.instance.SetCoinScore (coinScore);
				GameplayController.instance.SetLifeScore (lifeScore);

				PlayerScore.scoreCount = score;
				PlayerScore.coinCount = coinScore;
				PlayerScore.lifeCount = lifeScore;

			} 
			else if (gameStartedFromMainMenu) 
			{
				PlayerScore.scoreCount = 0;
				PlayerScore.coinCount = 0;
				PlayerScore.lifeCount = 2;

				GameplayController.instance.SetScore (0);
				GameplayController.instance.SetCoinScore (0);
				GameplayController.instance.SetLifeScore (2);
			}
		}
	}

	void InitializeVariables()
	{
		if (!PlayerPrefs.HasKey ("Game Initialized")) 
		{
			GamePreferences.SetEasyDifficultyState (0);
			GamePreferences.SetEasyDifficultyHighScore (0);
			GamePreferences.SetEasyDifficultyCoinScore (0);

			GamePreferences.SetMediumDifficultyState (1);
			GamePreferences.SetMediumDifficultyHighScore (0);
			GamePreferences.SetMediumDifficultyCoinScore (0);

			GamePreferences.SetHardDifficultyState (0);
			GamePreferences.SetHardDifficultyHighScore (0);
			GamePreferences.SetHardDifficultyCoinScore (0);

			GamePreferences.SetMusicState (0);

			PlayerPrefs.SetInt ("Game Initialized", 123);
		}
	}
	
	void MakeSingleton()
	{
		if (instance != null) 
		{
			Destroy (gameObject);
		} 
		else 
		{
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	public void CheckGameStatus(int score, int coinScore, int lifeScore)
	{
		if (lifeScore < 0) 
		{
			if (GamePreferences.GetEasyDifficultyState () == 1) 
			{
				int highscore = GamePreferences.GetEasyDifficultyHighScore ();
				int coinHighScore = GamePreferences.GetEasyDifficultyCoinScore ();

				if (highscore < score)
					GamePreferences.SetEasyDifficultyHighScore (score);

				if (coinHighScore < coinScore)
					GamePreferences.SetEasyDifficultyCoinScore (coinScore);
			}

			if (GamePreferences.GetMediumDifficultyState () == 1) 
			{
				int highscore = GamePreferences.GetMediumDifficultyHighScore ();
				int coinHighScore = GamePreferences.GetMediumDifficultyCoinScore ();

				if (highscore < score)
					GamePreferences.SetMediumDifficultyHighScore (score);

				if (coinHighScore < coinScore)
					GamePreferences.SetMediumDifficultyCoinScore (coinScore);
			}

			if (GamePreferences.GetHardDifficultyState () == 1) 
			{
				int highscore = GamePreferences.GetHardDifficultyHighScore ();
				int coinHighScore = GamePreferences.GetHardDifficultyCoinScore ();

				if (highscore < score)
					GamePreferences.SetHardDifficultyHighScore (score);

				if (coinHighScore < coinScore)
					GamePreferences.SetHardDifficultyCoinScore (coinScore);
			}
			
			gameStartedFromMainMenu = false;
			gameRestartedAfterPlayerDied = false;

			GameplayController.instance.GameOverShowPanel (score, coinScore);
		}
		else
		{
			this.score = score;
			this.coinScore = coinScore;
			this.lifeScore = lifeScore;

			gameStartedFromMainMenu = false;
			gameRestartedAfterPlayerDied = true;

			GameplayController.instance.PlayerDiedRestartTheGame ();
		}
	}







}
