using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class produceUnity : MonoBehaviour {


	public GameObject proUnityP;

	public GameObject UnityObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		if(Input.GetKeyDown(KeyCode.V)){

			if(GameDataB.Food>=200){


			Instantiate(UnityObject, proUnityP.transform.position, Quaternion.Euler(0, 0, 0));

			GameDataB.Food -= 200;


			}


		}


		
	}


	public void OnClick(){

		//if(GameDataB.Food>=200){


			//Instantiate(UnityObject, proUnityP.transform.position, Quaternion.Euler(0, 0, 0));

			//GameDataB.Food -= 200;


		//}
	


	
	
	
	}



}
