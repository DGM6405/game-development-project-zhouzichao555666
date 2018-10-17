using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityAA : MonoBehaviour {

    public int Health = 100;

     bool isAttackR = true;


    //public float attacktimeB = 2.0f;
   // float AttackTime = 0.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Health<=0) {

            Destroy(this);


        }

       
		
	}

    void OnTriggerStay(Collider collider) {



    }

    private void OnTriggerEnter(Collider other)
    {    




        if (other.tag == "Damage") {

           // print(Health);
            Health -= 10;
            isAttackR = false;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="Damage") {

            isAttackR = true;


        }
    }


}
