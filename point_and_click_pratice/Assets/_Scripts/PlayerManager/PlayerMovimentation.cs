using System.Diagnostics;
using UnityEngine;
using UnityEngine.Serialization;
using Debug = UnityEngine.Debug;


public class PlayerMovimentation : MonoBehaviour {
	public float movimentationSpeed, spinSpeed;
	public VirtualJoystick vj;
	public GameObject meshHolder;
	void Update () {
		Movimentation();	
	}

	private void Movimentation()
	{
		transform.Translate(vj.Horizontal() * movimentationSpeed * Time.deltaTime, vj.Vertical()*movimentationSpeed*Time.deltaTime,0);
		ClampPlayerOnScreen();
		// 	RotationLogic();
	}
	private void ClampPlayerOnScreen() {
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.4f, 2.4f),Mathf.Clamp(transform.position.y, -4.3f, 4.3f),0);
	}

	private void RotationLogic()
	{	
//		Debug.Log(vj.Horizontal());
		Debug.Log(vj.isMoving);
		if (vj.isMoving)
		{
			if (meshHolder.transform.rotation.x <= 25 && meshHolder.transform.rotation.x >= -25)
			{
				meshHolder.transform.Rotate(vj.Vertical() * spinSpeed * Time.deltaTime,
					0, 0);
			}
			if (meshHolder.transform.rotation.y <= 25 && meshHolder.transform.rotation.y >= -25)
			{
				meshHolder.transform.Rotate(0, vj.Horizontal() * spinSpeed * Time.deltaTime,
					0);
			}
			
		}
		else
		{
			if (meshHolder.transform.rotation.x >=0)
			{
				meshHolder.transform.Rotate(-spinSpeed * Time.deltaTime, 0, 0);
			}
			else
			{
				meshHolder.transform.Rotate(spinSpeed * Time.deltaTime, 0, 0);
			}
			if (meshHolder.transform.rotation.y >=0)
			{
				meshHolder.transform.Rotate(0,-spinSpeed * Time.deltaTime, 0);
			}
			else
			{
				meshHolder.transform.Rotate(0,spinSpeed * Time.deltaTime, 0);
			}
			if (meshHolder.transform.rotation.z >=0)
			{
				meshHolder.transform.Rotate(0, 0, -spinSpeed * Time.deltaTime);
			}
			else
			{
				meshHolder.transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
			}
		}
	}
}
