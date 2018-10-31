using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapointU : MonoBehaviour {


    public GameObject Sword;
    public GameObject Bow;

    bool Isweapon = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {

        if (!Isweapon)
        {
            if (other.tag == "WeaponPoint")
            {



                Instantiate(Sword, gameObject.transform.position, Quaternion.Euler(0, 0, 0), transform);

                Isweapon = true;

            }


            if (other.tag == "Bowponit")
            {



                Instantiate(Bow, gameObject.transform.position, Quaternion.Euler(0,95, 0), transform);
                Isweapon = true;

                showItem.arrow = true;

            }

        }
    }


}
