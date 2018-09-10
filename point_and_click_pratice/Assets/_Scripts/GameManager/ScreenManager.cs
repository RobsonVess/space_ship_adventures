using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour {
	private Dictionary<string ,GameObject> screens = new Dictionary<string, GameObject>();
	
	public ScreenSetUp[] ScreenSetUps;
	public static ScreenManager i;
	
	void Awake () {
		i = this;
		SetUpScreens("Main Menu");
	}

	private void SetUpScreens(string value) {
		foreach (var screen in ScreenSetUps) {
			screens.Add(screen.name, screen.screen);
		}
		ChangeScreen(value);
	}

	public void ChangeScreen(string value) {
		if (screens.ContainsKey(value)) {
			foreach (KeyValuePair<string,GameObject> screen in screens) {
				screen.Value.SetActive(false);
			}
			screens[value].SetActive(true);
		}
		else
		{
			Debug.Log("Screen not found");
		}
	}
}
[System.Serializable]
public struct ScreenSetUp {
	public string name;
	public GameObject screen;
}
