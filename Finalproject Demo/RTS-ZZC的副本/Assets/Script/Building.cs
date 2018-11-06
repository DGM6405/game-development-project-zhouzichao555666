using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

    // Use this for initialization



    public GameObject BuildModel;

    Camera cam;

    public LayerMask groundlayer;


    void Awake () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    private RaycastHit GetPointUnderCursor()
    {

        Vector2 screenPosition = Input.mousePosition;

       

        Ray ray = cam.ScreenPointToRay(screenPosition);

     
        RaycastHit hitPosition;
       
        Physics.Raycast(cam.transform.position, ray.direction, out hitPosition, 100, groundlayer);

        return hitPosition;

    }


}
