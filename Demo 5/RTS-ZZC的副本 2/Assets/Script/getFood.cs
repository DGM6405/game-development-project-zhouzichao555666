using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFood : MonoBehaviour {

    // Use this for initialization
  
    private bool isgetFood = false;
    private float timer = 0f;


    public int getFoodS = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        if (isgetFood)
        {

			timer += Time.deltaTime;

            if (timer >= 5f)
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

			getFoodS += 20;

            isgetFood = true;


        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Unities" || other.tag == "isSelectedUnity")
        {
			getFoodS -= 20;
			if (getFoodS <= 0) {
				isgetFood = false;
			}
        }
    }

}
