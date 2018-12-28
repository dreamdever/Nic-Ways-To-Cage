using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kviz
{



    private List<Toggle> Tlacidla { get; set; }
    private Toggle Spravna { get; set; }
    private Toggle Odpoved { get; set; }
    private int Body { get; set; }
    private SuborOtazok Subor { get; set; }
    private Text Otazka { get; set; }
    private bool Dalej { get; set; }
    private Button Button { get; set; }
    private bool Koniec { get; set; }

    public event System.EventHandler Stop;

    public Kviz(Object[] tlacidla, int kod, Text text, Button tlacidlo)
    {
        KategoriaOtazok kategoria = new KategoriaOtazok();
        Subor = kategoria.Subor[kod];
        Otazka = text;

        Tlacidla = new List<Toggle>();
        Body = 0;
        for (int i = 0; i < tlacidla.Length; i++)
        {
            Toggle button = (Toggle)tlacidla[i];
            button.onValueChanged.AddListener(delegate { Click(button); });
            Tlacidla.Add(button);
        }
        tlacidlo.onClick.AddListener(delegate { Stlacenie(tlacidlo); });
        Dalej = false;
        Koniec = false;
        Button = tlacidlo;
        Generovanie();
    }

    private void Click(Toggle button)
    {
        if (Dalej == true)
        {
            foreach (Toggle toggle in Tlacidla)
                if (Odpoved != button)
                    toggle.isOn = false;
            if (Odpoved.isOn == false)
                Odpoved.isOn = true;
        }
        else
        {
            if (button.isOn == true)
            {
                /*
                if (button == Spravna)
                {
                    Body++;
                }

                Generovanie();
                */

                foreach (Toggle toggle in Tlacidla)
                    if (toggle != button)
                        toggle.isOn = false;

            }
        }


    }

    private void Stlacenie(Button button)
    {
        if (Koniec == true)
            return;

        //Overenie
        int pocitadlo;
        for (pocitadlo = 0; pocitadlo < Tlacidla.Count; pocitadlo++)
            if (Tlacidla[pocitadlo].isOn == true)
                break;
        if (pocitadlo == Tlacidla.Count)
            return;

        if (Dalej == false)
        {
            Dalej = true;
            foreach (Toggle odpoved in Tlacidla)
                if (odpoved.isOn == true)
                    Odpoved = odpoved;

            if (Odpoved == Spravna)
            {
                Body++;
                Otazka.text = "Spravne";
                Odpoved.GetComponentInChildren<Text>().color = Color.green;
            }
            else
            {
                Otazka.text = "Nespravne";
                Odpoved.GetComponentInChildren<Text>().color = Color.red;

                Spravna.GetComponentInChildren<Text>().color = Color.green;
            }

            Button.GetComponentInChildren<Text>().text = "Ďalej";
        }
        else
        {
            Generovanie();
        }
    }

    private void Generovanie()
    {
        Dalej = false;
        Otazky otazky = Subor.Next();
        if (otazky == null)
        {
            Vyhodnotenie();
        }
        else
        {
            Otazka.text = otazky.Otazka;


            List<int> Indexy = new List<int>();

            //Vytvorenie listu s počtom indexov
            for (int i = 0; i < Tlacidla.Count - 1; i++)
                Indexy.Add(i);

            //Vybratie nahodneho tlačidla pre spravnu odpoved
            System.Random random = new System.Random();
            int temp = random.Next(0, Indexy.Count - 1);

            Tlacidla[Indexy[temp]].GetComponentInChildren<Text>().text = otazky.Spravne[random.Next(0, otazky.Spravne.Count)];
            Tlacidla[Indexy[temp]].GetComponentInChildren<Text>().color = Color.black;
            Spravna = Tlacidla[Indexy[temp]];
            Spravna.isOn = false;
            ColorBlock color = Spravna.colors;
            color.normalColor = Color.white;
            color.highlightedColor = Color.white;
            Spravna.colors = color;
            Indexy.RemoveAt(temp);


            //Vybratie zvyšných odpovedí 
            while (Indexy.Count != 0)
            {
                temp = random.Next(0, Indexy.Count - 1);
                int indexnespravna = random.Next(0, otazky.Nespravne.Count - 1);
                Tlacidla[Indexy[temp]].GetComponentInChildren<Text>().text = otazky.Nespravne[indexnespravna];
                Tlacidla[Indexy[temp]].GetComponentInChildren<Text>().color = Color.black;
                Tlacidla[Indexy[temp]].isOn = false;
                Tlacidla[Indexy[temp]].colors = color;
                otazky.Nespravne.RemoveAt(indexnespravna);
                Indexy.RemoveAt(temp);

            }

            Button.GetComponentInChildren<Text>().text = "Vyhodnotiť";

        }

    }

    private void Vyhodnotenie()
    {
        Koniec = true;
        Otazka.text = string.Format("Počet správnych odpovedí {0}", Body.ToString());
        Button.GetComponentInChildren<Text>().text = "Koniec";
        Stop(this, System.EventArgs.Empty);
    }

}
