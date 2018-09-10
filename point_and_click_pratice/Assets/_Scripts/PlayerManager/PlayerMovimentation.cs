using UnityEngine;
using UnityEngine.Serialization;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovimentation : MonoBehaviour {
	public float movimentationSpeed, spinSpeed;

	void Update () {
		Movimentation();	
	}

	private void Movimentation() {
		transform.Translate(CrossPlatformInputManager.GetAxis("Horizontal")*movimentationSpeed*Time.deltaTime,CrossPlatformInputManager.GetAxis("Vertical")*movimentationSpeed*Time.deltaTime,0);
		ClampPlayerOnScreen();
	}
	private void ClampPlayerOnScreen() {
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.4f, 2.4f),Mathf.Clamp(transform.position.y, -4.3f, 4.3f),0);
	}

	private void ClampSpin() {
		if (CrossPlatformInputManager.GetAxis("Horizontal")!=0) {
			transform.rotation = new Quaternion(0,0,Mathf.Clamp(transform.rotation.z,-15f,15f) * CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * spinSpeed,0);
		} else {
			
		}
	}
}
