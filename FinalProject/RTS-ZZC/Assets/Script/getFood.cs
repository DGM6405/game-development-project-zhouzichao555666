using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFood : MonoBehaviour {

    // Use this for initialization
  
    private bool isgetFood = false;
    private float timer = 0f;


    public int getFoodS = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        if (isgetFood)
        {

            timer += Time.time;

            if (timer >= 100f)
            {

                GameDataB.Food += getFoodS;

                timer = 0f;


            }


        }





    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Unities" || other.tag == "isSelectedUnity")
        {



            isgetFood = true;


        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Unities" || other.tag == "isSelectedUnity")
        {

            isgetFood = false;

        }
    }

}
