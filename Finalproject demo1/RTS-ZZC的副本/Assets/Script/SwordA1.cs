using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordA1 : MonoBehaviour {


    public Space rotateSpace;
    //float m_timer = 0;

    


    private bool isAttack = false;
    private bool isAttack2 = false;
    private bool Attackback = false;
    // Use this for initialization
    void Start () {
		
	}


	
	// Update is called once per frame
	void Update () {

         

            
        


        if (isAttack) {

            transform.Rotate(new Vector3(0, 0, 3), rotateSpace);

         //   Debug.Log(transform.rotation.z);

            if (transform.rotation.z >= 0.8||transform.rotation.z<=-0.71)
            {


                isAttack = false;



                isAttack2 = true;


            }



        }

        if (isAttack2) {

         //   Debug.Log(transform.rotation.z);

            transform.Rotate(new Vector3(0, 0, -3), rotateSpace);

            

            if (transform.rotation.z <=0)
            {

              

                isAttack = true;



                isAttack2 = false;


            }


        }

        if (Attackback) {

           

           transform.Rotate(new Vector3(0, 0, -3), rotateSpace);
            if (transform.rotation.z <= 0.05)
            {

                Attackback = false;
            }



        }


        //        m_timer = 0;
        //   }
        // }
        // }


    }

void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "Unities"||collider.tag== "isSelectedUnity")
        {
            isAttack = true;
        }


        //for (int i = 0; i < 90; i++)
        //{
        //  transform.Rotate(new Vector3(0, 0, 1), rotateSpace);
        //   yield return null;
        //transform.Rotate(new Vector3(0, 0, -90), rotateSpace);

        //  timelate();
        // }


    }


    private void OnTriggerStay(Collider other)

    {


     
        //  print("enter");

        //  Debug.Log(transform.rotation.z);

    }


    private void OnTriggerExit(Collider other)
   {

        if (GetComponent<Collider>().tag == "Unities" || GetComponent<Collider>().tag == "isSelectedUnity") {

            isAttack = false;
            isAttack2 = false;
            Attackback = true;
        }

   }


    // private IEnumerator timelate() {

    // print("enter"+"adsfa");

    //  yield return new WaitForSeconds(5);
    //}
    // private void isEnmeyinRange() {



    //}

   



}
