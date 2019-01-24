using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Uvod : MonoBehaviour {

    private Kviz Quiz { get; set; }
    private GameObject Okno { get; set; }

	// Use this for initialization
	void Start () {
        
        GameObject objekt = GameObject.Find("Okno");
        while (objekt == null)
            objekt = GameObject.Find("Okno");
        objekt.SetActive(false);
        Okno = objekt;



        UnityEngine.Object[] butons = Resources.FindObjectsOfTypeAll(typeof(Button));
        for (int i = 0; i < butons.Length; i++)
        {
            Button buton = (Button)butons[i];
            if (buton.name == "OdpovedAno")
            {
                buton.onClick.AddListener(delegate { Ano(); });
                continue;
            }
            if (buton.name == "OdpovedNie")
            {
                buton.onClick.AddListener(delegate { Nie(); });
                continue;
            }

        }


        

        UnityEngine.Object[] list = Resources.FindObjectsOfTypeAll(typeof(Toggle));
        Text temp = GameObject.Find("Otazka").GetComponent<Text>();
        UnityEngine.Object[] tlacidla = Resources.FindObjectsOfTypeAll(typeof(Button));
        Button button = null;
        for (int i = 0; i < tlacidla.Length; i++)
        {
            button = (Button)tlacidla[i];
            if (button.name == "Tlacidlo")
                break;
        }
        if (button != null)
            Quiz = new Kviz(list, 0, temp, button);
        Quiz.Stop += Koniec;

    }

    

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("escape"))
        {
            //SceneManager.LoadScene("Intro");
            Okno.SetActive(true);
            

        }
    }


    //Toto sa zavolá na koniec
    void Koniec (object sender,System.EventArgs e)
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Ano()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Nie()
    {
        Okno.SetActive(false);
    }

}

