using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	public GameObject button, content;
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

	public void DebugLabel()
	{
	    GameObject buttons = Instantiate(button);
		buttons.transform.SetParent(content.transform);
	}
}
