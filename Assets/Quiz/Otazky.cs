using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otazky  {

    public string Otazka { get; set; }
    public List<string> Spravne { get; set; }
    public List<string> Nespravne { get; set; }

    public Otazky()
    {
        Otazka = string.Empty;
        Spravne = new List<string>();
        Nespravne = new List<string>();
    }

}
