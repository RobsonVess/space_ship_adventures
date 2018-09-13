using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
	
	public GameObject saveLabel, createSaveScreen, saveContent;
	public List<GameObject> labelsInContent;
	public InputField inputName;
	public Text placeHolder;
	public string savePath;
	private int ActiveSave;
	
	public static PlayerManager i;
	
	private void Awake() {
		i = this;
		savePath = Application.persistentDataPath + "/save.karol";
		Debug.Log(savePath);
	}

	

	public List<GameObject> labels;
	// Save and Load functions
	
	public Save save = new Save();
	
	
	
	public void OpenCreateSaveScreen()
	{
		placeHolder.text = "Your Name...";
		inputName.text = "";
		createSaveScreen.SetActive(true);
	}
	public void CloseCreateScreen()
	{
		createSaveScreen.SetActive(false);
	}

	public void CreateASave() {
		PlayerSave playerSave = new PlayerSave();
		playerSave.playerName = inputName.text;
		playerSave.dateAndOur = DateTime.Now.ToString();
		save.playerSaves.Add(playerSave);
		Save();
		CloseCreateScreen();
		PopulateSaveSelector();
	}
	private void Save()
	{
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Create(savePath);
			bf.Serialize(file, save);
			file.Close();
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
			PopulateSaveSelector();
		}
		else
		{
			Debug.Log("Dont have save");				
		}
	}
	public void HaveSave()
	{
		LoadSaves();
		if (save.playerSaves.Count == 0)
		{
			OpenCreateSaveScreen();
		}
	}

	private void PopulateSaveSelector() {
		foreach (GameObject gameObject in labelsInContent) {
			Destroy(gameObject);
		}
		labelsInContent.Clear();
		foreach (PlayerSave save in save.playerSaves) {
			GameObject instance = Instantiate(saveLabel, saveContent.transform.position, saveContent.transform.rotation);
			instance.GetComponent<SaveLabel>().name.text = save.playerName;
			instance.GetComponent<SaveLabel>().dateAndOur.text = save.dateAndOur;
			instance.transform.SetParent(saveContent.transform);
			instance.transform.localScale = new Vector3(1, 1, 1);
			labelsInContent.Add(instance);
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
	//public List<SpaceShip> SpaceShips;

	
}
[Serializable]
public class Save
{
	public List<PlayerSave> playerSaves = new List<PlayerSave>();
}