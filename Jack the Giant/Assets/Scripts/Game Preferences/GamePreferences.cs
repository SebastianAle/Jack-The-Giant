using UnityEngine;
using System.Collections;

public static class GamePreferences 
{

	public static string EasyDifficulty = "EasyDifficulty";
	public static string MediumDifficulty = "MediumDifficulty";
	public static string HardDifficulty = "HardDifficulty";

	public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
	public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
	public static string HardDifficultyHighScore = "HardDifficultyHighScore";

	public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
	public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
	public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

	public static string IsMusicOn = "IsMusicOn";

	//NOTE we are going to use intergers to represent boolean variables
	// 0 - false
	// 1 - true

	public static int GetMusicState()
	{
		return PlayerPrefs.GetInt (GamePreferences.IsMusicOn);
	}
	//0 is off - 1 is on
	public static void SetMusicState(int state)
	{
		PlayerPrefs.SetInt (GamePreferences.IsMusicOn, state);
	}



	//method for getting Easy difficulty state
	public static int GetEasyDifficultyState()
	{
		return PlayerPrefs.GetInt (GamePreferences.EasyDifficulty);
	}
	public static void SetEasyDifficultyState(int difficulty)
	{
		PlayerPrefs.SetInt (GamePreferences.EasyDifficulty, difficulty);
	}

	//method for getting Medium difficulty state
	public static int GetMediumDifficultyState()
	{
		return PlayerPrefs.GetInt (GamePreferences.MediumDifficulty);
	}
	public static void SetMediumDifficultyState(int difficulty)
	{
		PlayerPrefs.SetInt (GamePreferences.MediumDifficulty, difficulty);
	}

	//method for getting Hard difficulty state
	public static int GetHardDifficultyState()
	{
		return PlayerPrefs.GetInt (GamePreferences.HardDifficulty);
	}
	public static void SetHardDifficultyState(int difficulty)
	{
		PlayerPrefs.SetInt (GamePreferences.HardDifficulty, difficulty);
	}



	//method for getting Easy difficulty highscore
	public static int GetEasyDifficultyHighScore()
	{
		return PlayerPrefs.GetInt (GamePreferences.EasyDifficultyHighScore);
	}
	public static void SetEasyDifficultyHighScore(int score)
	{
		PlayerPrefs.SetInt (GamePreferences.EasyDifficultyHighScore, score);
	}
		
	//method for getting Medium difficulty highscore
	public static int GetMediumDifficultyHighScore()
	{
		return PlayerPrefs.GetInt (GamePreferences.MediumDifficultyHighScore);
	}
	public static void SetMediumDifficultyHighScore(int score)
	{
		PlayerPrefs.SetInt (GamePreferences.MediumDifficultyHighScore, score);
	}

	//method for getting Hard difficulty highscore
	public static int GetHardDifficultyHighScore()
	{
		return PlayerPrefs.GetInt (GamePreferences.HardDifficultyHighScore);
	}
	public static void SetHardDifficultyHighScore(int score)
	{
		PlayerPrefs.SetInt (GamePreferences.HardDifficultyHighScore, score);
	}



	//method for getting Easy difficulty coinscore
	public static int GetEasyDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt (GamePreferences.EasyDifficultyCoinScore);
	}
	public static void SetEasyDifficultyCoinScore(int coinscore)
	{
		PlayerPrefs.SetInt (GamePreferences.EasyDifficultyCoinScore, coinscore);
	}

	//method for getting Medium difficulty coinscore
	public static int GetMediumDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt (GamePreferences.MediumDifficultyCoinScore);
	}
	public static void SetMediumDifficultyCoinScore(int score)
	{
		PlayerPrefs.SetInt (GamePreferences.MediumDifficultyCoinScore, score);
	}

	//method for getting Hard difficulty coinscore
	public static int GetHardDifficultyCoinScore()
	{
		return PlayerPrefs.GetInt (GamePreferences.HardDifficultyCoinScore);
	}
	public static void SetHardDifficultyCoinScore(int score)
	{
		PlayerPrefs.SetInt (GamePreferences.HardDifficultyCoinScore, score);
	}
}
