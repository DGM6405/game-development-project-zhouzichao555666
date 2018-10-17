using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseflood : MonoBehaviour {

    public GameObject BuildModel;

    Camera cam;
    // Use this for initialization
    void Awake () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {

            print("1");

            //Debug.Log(gameObject);
          //  Debug.Log(GetPointUnderCursor().collider.gameObject);

            if (gameObject == GetPointUnderCursor().collider.gameObject)
            {

                print("3");

                Instantiate(BuildModel, gameObject.transform.position, Quaternion.identity);


            }


        }
	}

    private RaycastHit GetPointUnderCursor()
    {



        print("2");

        Vector2 screenPosition = Input.mousePosition;



        Ray ray = cam.ScreenPointToRay(screenPosition);


        RaycastHit hitPosition;

        Physics.Raycast(cam.transform.position, ray.direction, out hitPosition, 100);

        return hitPosition;


      

    }

}
