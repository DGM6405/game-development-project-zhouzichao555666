using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Playercontroller : MonoBehaviour {

    Camera cam;
    public LayerMask groundlayer;

    public NavMeshAgent playerAgent;

    private GameObject player;

    float camz = 100;

   // private bool isSelected = false;


    public GameObject[] Unities;
    public GameObject[] isSeUnities;

    // new Vector3 dd;
    // Use this for initialization
    void Awake() {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {


	//	print (isSeUnities);

        if (Input.GetMouseButtonDown(1)) {

            unitiesMovement();

           // playerAgent.SetDestination(GetPointUnderCursor());

        }

        if (Input.GetMouseButtonDown(0))
        {
            //if (!isSelected) {


			if((GetPointUnderCursor2().collider.gameObject.tag!="Unities")&&(GetPointUnderCursor2().collider.gameObject.tag!="isSelectedUnity")){


                reUnities();
			}
           // }


        }
        if (Input.GetMouseButtonUp(0))
        {
            activeUnities();


        }








    }


	void LateUpdate(){}




    private Vector3 GetPointUnderCursor() {

        Vector2 screenPosition = Input.mousePosition;

        // dd = new Vector3 (screenPosition.x, screenPosition.y, camz);

        //Debug.Log(dd);

        // Vector3 mouseWorldPosition = cam.ScreenToWorldPoint(dd);

        Ray ray = cam.ScreenPointToRay(screenPosition);

        //Debug.Log(mouseWorldPosition);



        RaycastHit hitPosition;
        //Physics.Raycast(mouseWorldPosition,cam.transform.forward,out hitPosition,100,groundlayer);

        Physics.Raycast(cam.transform.position,ray.direction,out hitPosition,100,groundlayer);

        //Debug.DrawLine(mouseWorldPosition, hitPosition.point, Color.red);
      //  Debug.Log(hitPosition.collider);

        return hitPosition.point;

    }


   



    private void activeUnities() {




        Unities = GameObject.FindGameObjectsWithTag("Unities");



        for (var i = 0; i <= Unities.Length - 1; i++)
        {




            if (selectBox.IsWithinSelectionBounds(Unities[i]))
            {

              

                Unities[i].transform.Find("Select").gameObject.SetActive(true);
                Unities[i].tag = "isSelectedUnity";

                
            }


        }

    }

    private void reUnities()
    {
        isSeUnities = GameObject.FindGameObjectsWithTag("isSelectedUnity");


        for (var i = 0; i <= isSeUnities.Length - 1; i++)
        {
            isSeUnities[i].transform.Find("Select").gameObject.SetActive(false);
            isSeUnities[i].tag = "Unities";

        }
    }

    private void unitiesMovement() {


        isSeUnities = GameObject.FindGameObjectsWithTag("isSelectedUnity");




        for (var i = 0; i <= isSeUnities.Length - 1; i++)
        {
            playerAgent = isSeUnities[i].GetComponent<NavMeshAgent>();
            playerAgent.SetDestination(GetPointUnderCursor());

        }

    }




	private RaycastHit GetPointUnderCursor2()
	{





		Vector2 screenPosition = Input.mousePosition;



		Ray ray = cam.ScreenPointToRay(screenPosition);


		RaycastHit hitPosition;

		Physics.Raycast(cam.transform.position, ray.direction, out hitPosition, 100);

		return hitPosition;




	}




   // private void isArrows() {
   
   //     isSeUnities = GameObject.FindGameObjectsWithTag("isSelectedUnity");

     //   for (var i = 0; i <= isSeUnities.Length - 1; i++)
       // {
         //   if (isSeUnities[i].transform.Find("HOldPOint").) {

         //       showItem.arrow = true;


         //   }

        //}

    //}

}
