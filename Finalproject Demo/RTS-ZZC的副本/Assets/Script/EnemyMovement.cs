using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour {

    public NavMeshAgent playerAgent;


    public GameObject[] Unities;
    public GameObject[] isSeUnities;

    private float Edistance=float.MaxValue ;


    public GameObject Aspoint;

    private GameObject target;


    // Use this for initialization
    void Awake () {

		playerAgent = gameObject.GetComponent<NavMeshAgent>();


    }

    private void Start()
    {




        playerAgent.SetDestination(Aspoint.transform.position);


    }

    // Update is called once per frame
    void Update () {

        attackunity();

        if (Edistance<8) {

            playerAgent.SetDestination(target.transform.position);

        }
       


		
	}


    void attackunity() {

        Unities = GameObject.FindGameObjectsWithTag("Unities");
        isSeUnities = GameObject.FindGameObjectsWithTag("isSelectedUnity");

        float tem1 = float.MaxValue;

        for (int i = 0; i < Unities.Length; i++) {

            tem1 = Vector3.Distance(Unities[i].transform.position, transform.position);

            if (Edistance>=tem1) {

                Edistance = tem1;
                target = Unities[i];

            }
       


           

        }

        for (int j=0;j<isSeUnities.Length;j++) {


            tem1 = Vector3.Distance(isSeUnities[j].transform.position, transform.position);


            if (Edistance >= tem1)
            {

                Edistance = tem1;
                target = isSeUnities[j];

            }

        }










    }





}
