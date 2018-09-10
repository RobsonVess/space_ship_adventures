using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

	public static LevelManager i;
		
	private void Awake()
	{
		i = this;
	}
	// Make a list of panels
	public void LevelSelect(int value)
	{
		ScreenManager.i.ChangeScreen("Game Level");
	}
}
