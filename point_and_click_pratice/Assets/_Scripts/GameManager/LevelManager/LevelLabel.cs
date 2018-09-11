using UnityEngine;
using UnityEngine.UI;
public class LevelLabel : MonoBehaviour
{
	public Image backGround;
	public Text labelTitle, buttonTitle;
	public Button button;

	public void LabelSetup(string labelTitle = "Empty", string buttonTitle = "Go!")
	{
		this.labelTitle.text = labelTitle;
		this.buttonTitle.text = buttonTitle;
	}
	
}
