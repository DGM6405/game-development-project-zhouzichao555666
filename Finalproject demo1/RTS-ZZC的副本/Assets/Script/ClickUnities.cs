using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUnities : MonoBehaviour {

	Camera cam;

	// Use this for initialization
	void Awake () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {




		if (Input.GetMouseButtonDown (0)) {




			if(GetPointUnderCursor().collider.gameObject.tag=="Unities"){


			//	print ("adsfa");

				GetPointUnderCursor().collider.gameObject.tag = "isSelectedUnity";

				GetPointUnderCursor().transform.Find("Select").gameObject.SetActive(true);


			}
		
		
		}




		
	}




	private RaycastHit GetPointUnderCursor()
	{





		Vector2 screenPosition = Input.mousePosition;



		Ray ray = cam.ScreenPointToRay(screenPosition);


		RaycastHit hitPosition;

		Physics.Raycast(cam.transform.position, ray.direction, out hitPosition, 100);

		return hitPosition;




	}
}
