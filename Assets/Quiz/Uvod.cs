using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uvod : MonoBehaviour {

    private Kviz Quiz { get; set; }

	// Use this for initialization
	void Start () {
        UnityEngine.Object[] list = Resources.FindObjectsOfTypeAll(typeof(Toggle));
        Text temp = GameObject.Find("Otazka").GetComponent<Text>();
        UnityEngine.Object[] tlacidla = Resources.FindObjectsOfTypeAll(typeof(Button));
        if (tlacidla.Length == 1)
            Quiz = new Kviz(list, 0, temp, (Button)tlacidla[0]);
        Quiz.Stop += Koniec;

    }

    

    // Update is called once per frame
    void Update () {
		
	}


    //Toto sa zavolá na koniec
    void Koniec (object sender,System.EventArgs e)
    {
        
    }

}

