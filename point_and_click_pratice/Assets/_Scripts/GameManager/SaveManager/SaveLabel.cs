using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLabel : MonoBehaviour
{

	public Text name;
	public Text dateAndOur;
	public int id;

	public void ActiveSave() {
		PlayerManager.i.ActiveSave = id;
	}
}
