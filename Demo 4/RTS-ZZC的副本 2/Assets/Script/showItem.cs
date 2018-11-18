using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showItem : MonoBehaviour {


    public static bool arrow = false;

	Camera cam;
	// Use this for initialization
	void Awake () {


		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {


        if (arrow) {
            gameObject.transform.Find("Arrow").gameObject.SetActive(true);


        }
        if (!arrow) {

            gameObject.transform.Find("Arrow").gameObject.SetActive(false);
        }



		if(Input.GetMouseButton(0)){


			if (GetPointUnderCursor ().transform.tag == "Base") {





			gameObject.transform.Find ("HiringFarmer").gameObject.SetActive (true);



		} else {


		
			gameObject.transform.Find ("HiringFarmer").gameObject.SetActive (false);
		
		
		
		
		
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
