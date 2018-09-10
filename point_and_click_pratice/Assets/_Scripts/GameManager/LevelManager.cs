using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

	public static LevelManager i;
	public GameObject levelBtn, viewPort;
	
	private void Awake()
	{
		i = this;
	}

	public void DebugButton()
	{
		GameObject buton = Instantiate(levelBtn);
		buton.transform.SetParent(viewPort.transform);
	}
}
