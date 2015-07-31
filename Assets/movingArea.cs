using UnityEngine;
using System.Collections;

public class movingArea : MonoBehaviour {
	
//	public float xMin, xMax, yMin, yMax;
	void Update()
	{
		float Xmove = Input.GetAxis ("Horizontal") * Time.deltaTime * 20;
		float Zmove = Input.GetAxis ("Vertical") * Time.deltaTime * 20;

		transform.Translate (Xmove,0f, Zmove);

		transform.position = new Vector3(Mathf.Clamp (transform.position.x,-180f, 1260f), 65f, Mathf.Clamp (transform.position.z,-318f, 425f));


	}
}