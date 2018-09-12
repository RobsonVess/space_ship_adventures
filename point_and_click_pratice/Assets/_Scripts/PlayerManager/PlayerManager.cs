using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
	
	
	// Save and Load functions
	
}

[System.Serializable]
public class PlayerSave
{
	public string playerName;
	public int playerLevel;
	public int playerExperience;
	public int playerMoney;
	public List<SpaceShip> SpaceShips;
}
public class Save
{
	public List<PlayerSave> playerSaves;
}