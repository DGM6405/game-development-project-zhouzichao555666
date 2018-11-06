using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShot : MonoBehaviour {


    public GameObject arrow;

    private float m_timer = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 



        


            //  Instantiate(arrow,gameObject.transform,true);
		m_timer += Time.deltaTime;
            if (m_timer >= 3f)
            {

            if (Input.GetKeyDown(KeyCode.A))
            {

                Instantiate(arrow, gameObject.transform.position, Quaternion.Euler(-90, 0, 0), transform);
                
            }
            m_timer = 0;
        }


		
	}
}
