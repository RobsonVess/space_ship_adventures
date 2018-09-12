using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
	
	public GameObject saveLabel, createSaveScreen;
	public InputField inputName;
	public Text placeHolder;
	public string savePath;

	private void Awake()
	{
		savePath = Application.persistentDataPath + "/save.dat";
	}

	public List<GameObject> labels;
	// Save and Load functions
	
	public Save save;
	
	
	
	public void OpenCreateSaveScreen()
	{
		placeHolder.text = "Your Name...";
		createSaveScreen.SetActive(true);
	}

	public void CloseCreateScreen()
	{
		createSaveScreen.SetActive(false);
	}
	private void Save()
	{
		if (File.Exists(savePath))
		{
			
		}
		else
		{
			BinaryFormatter bf = new BinaryFormatter();
//			FileStream file = 
		}
		
	}

	private void LoadSaves()
	{
		if (File.Exists(savePath))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(savePath, FileMode.Open);
			save = (Save) bf.Deserialize(file);
			file.Close();
		}
		else
		{
			OpenCreateSaveScreen();
		}
	}
	private bool HaveSave()
	{
		if (save.playerSaves.Count == 0)
		{
			return false;
		}
		else
		{
			return true;
		}
	}
	
	
	
}

[System.Serializable]
public class PlayerSave
{
	public string playerName;
	public string dateAndOur;
	public int playerLevel;
	public int playerExperience;
	public int playerMoney;
	public List<SpaceShip> SpaceShips;

	
}
public class Save
{
	public List<PlayerSave> playerSaves;
}