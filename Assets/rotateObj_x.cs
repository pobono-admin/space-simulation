using UnityEngine;
using System.Collections;

public class rotateObj_x : MonoBehaviour 
{
	
	public float speed;
	public float minAngle;
	public float maxAngle;


	private Vector3 _mouseReference;
	private Vector3 _mouseOffset;
	private Vector3 _rotation;
	private bool _isRotating;
	private float angle;
	private float axis;
	void Start ()
	{
		speed = 2f;
		minAngle = 40f;
		maxAngle=180f;
		_rotation = Vector3.zero;
	}
	
	void Update()
	{
		if (_isRotating) {


			// offset
			_mouseOffset = (Input.mousePosition - _mouseReference);
			
			// apply rotation
			_rotation.x = -(_mouseOffset.x + _mouseOffset.x) * speed;

			// rotate
			//transform.Rotate (_rotation);


			//print (_rotation);


			// store mouse
			//_mouseReference = Input.mousePosition;

//			// offset
//			_mouseOffset = (Input.mousePosition - _mouseReference);
//			
//			// apply rotation
			angle = -(_mouseOffset.x + _mouseOffset.x) * speed;
//			//print(_mouseOffset);
//			// rotate
//			transform.rotation = Vector3(angle,0f,0f);
//
			transform.localEulerAngles = new Vector3 (Mathf.Clamp(angle,-minAngle, maxAngle), 0f, 0);
//			// store mouse
//			_mouseReference = Input.mousePosition;

//			if (_rotation > 180f) {
//				transform.Rotate(maxAngle);
//			} else if (_rotation < 40f) {
//				transform.Rotate(minAngle);
//			}
		}

	}
	
	void OnMouseDown()
	{
		// rotating flag
		_isRotating = true;
		
		// store mouse
		_mouseReference = Input.mousePosition;
	}
	
	void OnMouseUp()
	{
		// rotating flag
		_isRotating = false;
	}


//	private float angle;
//	private float speed = 3.0f;
//
//	void Update(){
//
//		angle += .2f;
//		transform.eulerAngles = new Vector3 ( Mathf.Clamp (angle,-20f, 25f), 0, 0);
// 
//
//	}
//

}