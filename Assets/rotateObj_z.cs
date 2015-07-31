using UnityEngine;
using System.Collections;

public class rotateObj_z : MonoBehaviour 
{
	
	public float speed;
	public float minAngle;
	public float maxAngle;
	
	private Vector3 _mouseReference;
	private Vector3 _mouseOffset;
	private Vector3 _rotation;
	private bool _isRotating;
	private float angle;
	
	void Start ()
	{
		speed = 2f;
		minAngle = 0;
		maxAngle=360f;
		_rotation = Vector3.zero;
	}
	
	void Update()
	{
		if(_isRotating)
		{
			// offset
			_mouseOffset = (Input.mousePosition - _mouseReference);
			
			// apply rotation
			_rotation.y = -(_mouseOffset.x + _mouseOffset.y) * speed;



			// rotate
			transform.Rotate(_rotation);

			// store mouse
			_mouseReference = Input.mousePosition;
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
	
}