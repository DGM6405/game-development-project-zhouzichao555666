﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getGold : MonoBehaviour {



    private bool isgetGold = false;
 
    private float timer = 0f;

    public int getMoneyS = 30;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isgetGold) {

			timer += Time.deltaTime;

            if (timer>=5f) {

                GameDataB.Money += getMoneyS;

                timer = 0f;


            }


        }
    





    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag=="Unities"||other.tag=="isSelectedUnity") {

           

            isgetGold = true;


        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="Unities" || other.tag == "isSelectedUnity") {

            isgetGold = false;

        }
    }



}
