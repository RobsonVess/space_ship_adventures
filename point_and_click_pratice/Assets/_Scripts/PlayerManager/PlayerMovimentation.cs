using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovimentation : MonoBehaviour {
	public float speed;

	void Update () {
		Movimentation();	
	}

	private void Movimentation() {
		transform.Translate(CrossPlatformInputManager.GetAxis("Horizontal")*speed*Time.deltaTime,CrossPlatformInputManager.GetAxis("Vertical")*speed*Time.deltaTime,0);
		ClampPlayerOnScreen();
	}
	private void ClampPlayerOnScreen() {
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.4f, 2.4f),Mathf.Clamp(transform.position.y, -4.3f, 4.3f),0);
	}
}
