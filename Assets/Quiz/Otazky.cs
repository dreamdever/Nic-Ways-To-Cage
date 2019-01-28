using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otazky  {

    public string Otazka { get; set; }
    public List<string> Spravne { get; set; }
    public List<string> Nespravne { get; set; }
    private int ispravne;
    private int inespravne;

    public Otazky()
    {
        Otazka = string.Empty;
        Spravne = new List<string>();
        Nespravne = new List<string>();
        ispravne = 0;
        inespravne = 0;
    }

    public string NextSpravna()
    {
        if (ispravne < Spravne.Count)
        {
            string temp = Spravne[ispravne];
            ispravne++;
            return temp;
        }
        else
            return string.Empty;

    }

    public string NextNespravna()
    {
        if (inespravne < Nespravne.Count)
        {
            string temp = Nespravne[inespravne];
            inespravne++;
            return temp;
        }
        else
            return "Nieje odpoved";
    }

}
