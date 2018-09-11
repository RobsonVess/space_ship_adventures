using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	public GameObject levelLabel, content;
	public static LevelManager i;
		
	private void Awake()
	{
		i = this;
	}
	
	public void LevelSelect(int value)
	{
		ScreenManager.i.ChangeScreen("Game Level");
	}
	
	public void DebugLabel()
	{
	    GameObject Label = Instantiate(levelLabel);
		Label.transform.SetParent(content.transform);
		Label.transform.localScale = new Vector3(1, 1, 1);
	}
	
}

[System.Serializable]
public struct LevelRules
{
	public string levelName;
	public int levelId;

}