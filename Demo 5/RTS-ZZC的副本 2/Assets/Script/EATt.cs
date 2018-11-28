using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EATt : MonoBehaviour {



	private GameObject[] EnUnities;
	public static int enemynum=0;
	//private NavMeshAgent enAgent;
	//public GameObject attackpoint;


	private 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		EnUnities = GameObject.FindGameObjectsWithTag("Enemy");

		if(enemynum>=10){




			for (var i = 0; i < EnUnities.Length; i++) {
			
			
				EnUnities [i].GetComponent<NavMeshAgent> ().SetDestination (transform.position);
			
				enemynum = 0;
			
			
			}




		}





	}
}
