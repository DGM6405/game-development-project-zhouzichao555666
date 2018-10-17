using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapointU : MonoBehaviour {


    public GameObject weapon;
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



                Instantiate(weapon, gameObject.transform.position, Quaternion.Euler(0, 90, 0), transform);

            }

        }
    }


}
