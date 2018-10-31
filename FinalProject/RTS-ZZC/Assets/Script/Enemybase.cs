using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybase : MonoBehaviour {

    // Use this for initialization

    private int buildingHealth = 10000;

    private int attackNum = 0;


    private bool isAttacked = false;

    private float m_timer = 0f;

	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        if (isAttacked) {

            m_timer += Time.time;

            if (m_timer >= 90f)
            {

                buildingHealth -= (20 * attackNum);

                m_timer = 0f;


            }




        }
        if (buildingHealth<=0) {




        }




		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Unities" || other.tag == "isSelectedUnity")
        {

            attackNum += 1;

        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Unities" || other.tag == "isSelectedUnity")
        {

            isAttacked = true;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Unities" || other.tag == "isSelectedUnity")
        {

            isAttacked = false;

        }
    }





}
