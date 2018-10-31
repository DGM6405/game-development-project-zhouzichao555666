using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getWood : MonoBehaviour {

    // Use this for initialization
    
    private bool isgetWood = false;
   
    private float timer = 0f;

    public int getWoodS = 20;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    

        
        if (isgetWood)
        {

            timer += Time.time;

            if (timer >= 100f)
            {

                GameDataB.Wood += getWoodS;

                timer = 0f;


            }


        }
      





    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Unities" || other.tag == "isSelectedUnity")
        {



            isgetWood = true;


        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Unities" || other.tag == "isSelectedUnity")
        {

            isgetWood = false;

        }
    }

}
