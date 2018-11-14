using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataB : MonoBehaviour {


    public static int Money = 1000;
    public static int Wood = 500;
    public static int Food = 300;

    public Text moneyT;
    public Text woodT;
    public Text foodT;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moneyT.text = Money + "";
        woodT.text = Wood + "";
        foodT.text = Food + "";

		
	}
}
