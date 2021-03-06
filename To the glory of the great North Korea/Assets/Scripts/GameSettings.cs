﻿using UnityEngine;

public class GameSettings : MonoBehaviour
{
	public static float MasterVolume;
	public static float ScrollSpeed;
	public static float PanSpeed;
	public static int Difficulty;
	public static bool DebugMode;

	public float startMasterVolume = 1f;
	public float startScrollSpeed = 0.15f;
	public float startPanSpeed = 100f;
	public int startDifficulty = 5;
	public bool startDebugMode = false;

	void Start()
	{
		MasterVolume = startMasterVolume;
		ScrollSpeed = startScrollSpeed;
		PanSpeed = startPanSpeed;
		Difficulty = startDifficulty;
		DebugMode = startDebugMode;
	}
}
