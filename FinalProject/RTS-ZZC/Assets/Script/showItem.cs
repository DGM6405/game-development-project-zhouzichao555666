using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showItem : MonoBehaviour {


    public static bool arrow = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (arrow) {
            gameObject.transform.Find("Arrow").gameObject.SetActive(true);


        }
        if (!arrow) {

            gameObject.transform.Find("Arrow").gameObject.SetActive(false);
        }
		
	}
}
