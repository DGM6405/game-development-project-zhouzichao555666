using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseflood : MonoBehaviour {

    public GameObject BuildModel;


	public int woodnumberB=500;
    public int woodnumber=300;

    Camera cam;
    // Use this for initialization
    void Awake () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {



            //Debug.Log(gameObject);
          //  Debug.Log(GetPointUnderCursor().collider.gameObject);

            if (gameObject == GetPointUnderCursor().collider.gameObject)
            {


				if (BuildModel.transform.tag == "Base") {

					if (GameDataB.Wood >= woodnumber) {

						GameDataB.Wood -= woodnumberB;
						Instantiate (BuildModel, gameObject.transform.position, Quaternion.identity);
					}


				} else {
					if (GameDataB.Wood >= woodnumber) {

						GameDataB.Wood -= woodnumber;
						Instantiate (BuildModel, gameObject.transform.position, Quaternion.identity);
					}
				}
              


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
