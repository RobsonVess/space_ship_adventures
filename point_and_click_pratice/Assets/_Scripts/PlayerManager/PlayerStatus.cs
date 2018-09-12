using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
	public PlayerSave playerSave = new PlayerSave();
	

}
[System.Serializable]
public class PlayerSave
{
	private int shipsCount;

	public int ShipsCount
	{
		get
		{ shipsCount = Ships.Count; return shipsCount; }
	}

	public List<SpaceShip> Ships;
}
