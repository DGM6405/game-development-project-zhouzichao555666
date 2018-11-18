using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityAA : MonoBehaviour {

    public int Health = 100;

     bool isAttack = false;

   float timer = 0.0f;


    //public float attacktimeB = 2.0f;
   // float AttackTime = 0.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Health<=0) {

            Destroy(gameObject);


        }

        if (isAttack) {


            
			timer += Time.deltaTime;



            if (timer>=3.0f) {

                
                Health -= 20;
                timer = 0.0f;

            }

          



        }

       
		
	}

    void OnTriggerStay(Collider collider) {



    }

    private void OnTriggerEnter(Collider other)
    {    




        if (other.tag == "Sword") {

            
            isAttack = true;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="Sword") {

            isAttack = false;


        }
    }


}
