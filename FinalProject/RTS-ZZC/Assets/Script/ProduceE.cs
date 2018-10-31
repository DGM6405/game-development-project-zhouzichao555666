using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceE : MonoBehaviour {



    public GameObject enemyobject;



    private float m_timer = 0f;

    public float Elong =10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        m_timer += Time.deltaTime;

        if (m_timer >= Elong) {



            Instantiate(enemyobject, gameObject.transform.position, Quaternion.Euler(0, 0, 0));



            m_timer = 0;
        }

        print(m_timer);



		
	}
}
