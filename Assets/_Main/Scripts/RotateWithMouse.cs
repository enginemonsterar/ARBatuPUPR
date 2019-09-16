using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RotateWithMouse : MonoBehaviour {

	float rotSpeed = 0.2f;

	void OnMouseDrag(){
		float rotX = Input.GetAxis("Mouse X") * rotSpeed ;
		float rotY = Input.GetAxis("Mouse Y") * rotSpeed ;

		transform.RotateAround(Vector3.up, -rotX);
		transform.RotateAround(Vector3.right, rotY);
	}
}
