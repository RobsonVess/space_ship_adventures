using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class LevelLabel : MonoBehaviour
{
	public Image backGround;
	public Text labelTitle, buttonTitle;
	public Button button;

	private String LabelTitle
	{
		get { return labelTitle.text; }
		set { labelTitle.text = value; }
	}

	public void SetupLabel(string value = "empty")
	{
		LabelTitle = value;
	}
	
	
}
