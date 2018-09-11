using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
	public GameObject levelLabel, content;
	public List<LevelRules> levels;
	
	// Singleton
	public static LevelManager i;
		
	private void Awake()
	{
		i = this;
		LevelListUpdate();
	}
	
	public void LevelSelect(int value)
	{
		ScreenManager.i.ChangeScreen("Game Level");
	}

	public void LevelListUpdate()
	{
		int levelId = 0;
		
		foreach (var level in levels)
		{
			levelId++;
			level.levelId = levelId;
			LevelSetup(level.levelId+". "+level.levelName);
			if (level.levelType == LevelRules.LevelType.BossFight)
			{
				// TEM QUE MECHER AQUI NESSA BOSTA DE COR
			}
		}
	}
	
	// Debug
	public void DebugLabel(string value)
	{
	    LevelSetup(value);
	}

	private void LevelSetup(string value = "empty")
	{
		GameObject Label = Instantiate(levelLabel);	
		Label.transform.SetParent(content.transform);
		Label.transform.localScale = new Vector3(1, 1, 1);
		Label.GetComponent<LevelLabel>().SetupLabel(value);
	}
	
}

[System.Serializable]
public class LevelRules
{
	public enum LevelType { Normal, InfinityRun, BossFight }

	public LevelType levelType;
	public string levelName;
	public int levelId, minimumLevelToJoin;
}