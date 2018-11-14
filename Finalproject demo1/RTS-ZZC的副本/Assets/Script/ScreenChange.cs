using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ScreenChange : MonoBehaviour {



    public int ScreenNum = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		
	}

    public void OnClick() {


        print(ScreenNum);

        SceneManager.LoadScene(ScreenNum);



    }

}
