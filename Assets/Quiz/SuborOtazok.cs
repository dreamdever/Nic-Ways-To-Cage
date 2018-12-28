using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuborOtazok
{

    public int ID { get; set; }
    public List<Otazky> Otazky { get; set; }
    private int Index { get; set; }
    

    public SuborOtazok(int id)
    {
        ID = id;
        Otazky = new List<Otazky>();
        Index = 0;
    }

    public Otazky Next()
    {
        if (Index == Otazky.Count)
            return null;
        else
        {
            Otazky temp = Otazky[Index];
            Index++;
            return temp;
        }
    }
    

    
}
