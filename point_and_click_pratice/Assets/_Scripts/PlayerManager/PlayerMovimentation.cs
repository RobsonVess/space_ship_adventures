using UnityEngine;
using UnityEngine.Serialization;


public class PlayerMovimentation : MonoBehaviour {
	public float movimentationSpeed;
	public VirtualJoystick vj;
	void Update () {
		Movimentation();	
	}

	private void Movimentation()
	{
		transform.Translate(vj.Horizontal() * movimentationSpeed * Time.deltaTime, vj.Vertical()*movimentationSpeed*Time.deltaTime,0);
		ClampPlayerOnScreen();
	}
	private void ClampPlayerOnScreen() {
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.4f, 2.4f),Mathf.Clamp(transform.position.y, -4.3f, 4.3f),0);
	}
}
