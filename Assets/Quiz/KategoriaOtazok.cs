using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KategoriaOtazok
{
    public List<SuborOtazok> Subor { get; set; }

    public KategoriaOtazok()
    {
        Subor = new List<SuborOtazok>();
        Generovanie();
    }

    #region Generovanie

    private void Generovanie()
    {

        #region Zakladne

        SuborOtazok subor = new SuborOtazok(0);
        Otazky otazky = new Otazky
        {
            Otazka = "Čo môže spraviť pedagóg, pokiaľ študent používa počas vyučovania mobilný telefón?",
            Spravne = new List<string>
        {
            "Upozorniť študenta, aby odložil zariadenie.",
            "Zobrať mobilný telefón, ale vrátiť ho na konci vyučovania žiakovi alebo rodinnému príslušníkovi."
        },
            Nespravne = new List<string>()
        {
            "Zobrať mobilný telefón a nechať si ho vo svojom vlastníctve.",
            "Rozbiť mobilný telefón.",
            "Okamžite znížiť známku zo správania."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Aké sú právomoci pedagóga, ak učiteľ kreslí nevhodné obrázky?",
            Spravne = new List<string>
        {
            "Pokiaľ nereaguje na upozornenie, pedagóg má právo udeliť poznámku.",
            "Vyhodiť kresby.",
            "Dohodnúť si individuálny pohovor s rodičmi študenta."
        },
            Nespravne = new List<string>()
        {
            "Spáliť kresby.",
            "Kričať na študenta za nevhodné správanie.",
            "Okamžite znížiť známku zo správania."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Vyberte, čo je najúčinnejšou formou reakcie pedagóga pri opakovanom vyrušovaní žiaka počas vyučovania.",
            Spravne = new List<string>
        {
            "Pokiaľ sú vylúčené psychické poruchy u študenta, je možné poslať ho za výchovným poradcom.",
            "Zadať mu viac práce."
        },
            Nespravne = new List<string>()
        {
            "Kričať na študenta.",
            "Ignorovať študentove správanie.",
            "Okamžite mu udeliť zníženú známku zo správania."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Zvoľte najvhodnejší spôsob riešenia v prípade, že je žiak drzý k pedagógovi.",
            Spravne = new List<string>
        {
            "Zvážiť výchovného poradcu.",
            "Dohodnúť si individuálny pohovor s rodičmi študenta."
        },
            Nespravne = new List<string>()
        {
            "Okamžite udeliť zníženú známku zo správania.",
            "Hádať sa so študentom.",
            "Byť k študentovi drzý."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Akú aktivizačnú metódu vyučovania treba použiť v prípade, že žiak zaspí na vyučovaní?",
            Spravne = new List<string>
        {
            "Zakomponovať hry do vyučovania."
        },
            Nespravne = new List<string>()
        {
            "Namiesto vzdelávania hrať hry.",
            "Ignorovať situáciu a pokračovať v doterajšom štýle výučby.",
            "Aplikovať tresty na vyrušujúcich študentov."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Vyberte, ako by ste riešili situáciu, ak má žiak permanentný záchvat smiechu.",
            Spravne = new List<string>
        {
            "Zamestnať študenta prácou."
        },
            Nespravne = new List<string>()
        {
            "Vyvolať ho k odpovedi.",
            "Začať sa smiať spolu s ním.",
            "Poslať ho za dvere."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Čo môže vykonať pedagóg, pokiaľ žiak neustále mešká na vyučovanie?",
            Spravne = new List<string>
        {
            "Dohodnúť si individuálny pohovor s rodičmi študenta."
        },
            Nespravne = new List<string>()
        {
            "Zakaždým mu udeliť poznámku.",
            "Zakaždým ho dať odpovedať na známku.",
            "Udeliť zníženú známku zo správania."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Aký je postup v prípade, že žiak príde pedagógovi na vyučovanie pod vplyvom návykových látok ? ",
            Spravne = new List<string>
        {
            "Okamžite zavolať rodičom a zvážiť zníženú známku zo správania."
        },
            Nespravne = new List<string>()
        {
            "Znížiť známku zo správania.",
            "Udeliť mu poznámku a nechať ho ďalej v škole.",
            "Upozorniť rodičov, no nechať študenta ďalej v škole."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Čo by ste vybrali ako vhodnú voľbu riešenia, ak by ste prichytili žiaka pri užívaní alkoholu na toalete, pričom sa už neudrží na nohách?",
            Spravne = new List<string>
        {
            "Okamžite zavolať rodičom študenta, aby si preňho prišli."
        },
            Nespravne = new List<string>()
        {
            "Znížiť známku zo správania.",
            "Odobrať všetok alkohol a nechať ho ďalej v škole.",
            "Ignorovať situáciu."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Vyberte spôsob, ako by ste reagovali v prípade, že žiak fyzicky napadne svojho spolužiaka (bez známok viditeľného zranenia).",
            Spravne = new List<string>
        {
            "Dostať študentov od seba a okamžite upozorniť rodičov."
        },
            Nespravne = new List<string>()
        {
            "Okamžite zavolať rodičom.",
            "Iba od seba dostať študentov, aby sa nebili.",
            "Ignorovať situáciu, nakoľko ju pedagóg nemá ako vyriešiť."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Čo by ste spravili v prípade, že žiak je v amoku a fyzicky napadá ostatných spolužiakov? ",
            Spravne = new List<string>
        {
            "Zastaviť ho a okamžite zavolať jeho rodičom."
        },
            Nespravne = new List<string>()
        {
            "Ignorovať situáciu, nakoľko ju pedagóg nemá ako vyriešiť.",
            "Vyhrážať sa mu zníženou známkou zo správania.",
            "Iba zavolať rodičom a oznámiť im, ako sa študent správa."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Ako by ste postupovali v prípade, že sa vám žiak vyhráža, že vyskočí z okna, keď dostal zlé hodnotenie? ",
            Spravne = new List<string>
        {
            "Racionálne sa porozprávať so študentom a dať mu možnosť opravenia známky."
        },
            Nespravne = new List<string>()
        {
            "Ignorovať situáciu.",
            "Zmeniť hodnotenie.",
            "Vysmiať sa študentovi."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Ako môže pedagóg postupovať v prípade, že nájde skupinu žiakov fajčiť cigarety na toalete?",
            Spravne = new List<string>
        {
            "Oznámiť rodičom, čo sa deje, a zvážiť výchovného poradcu."
        },
            Nespravne = new List<string>()
        {
            "Ignorovať situáciu.",
            "Kričať na študentov za nevhodné správanie.",
            "Okamžite udeliť zníženú známku zo správania."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Ako môže postupovať žiak v prípade, že ho začne pedagóg urážať?",
            Spravne = new List<string>
        {
            "Oznámiť správania pedagóga jeho nadriadenému.",
            "Otazka 5 Spravna 2",
            "Otazka 5 Spravna 3"
        },
            Nespravne = new List<string>()
        {
            "Kamerovať si pedagóga.",
            "Hádať sa s pedagógom a taktiež ho urážať.",
            "Fyzicky napadnúť pedagóga."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Ako môže postupovať pedagóg v prípade, že ho začne žiak urážať?",
            Spravne = new List<string>
        {
            "Oboznámiť rodičov s jeho správaním s zvážiť zníženú známku zo správania."
        },
            Nespravne = new List<string>()
        {
            "Urážať študenta naspäť.",
            "Okamžite udeliť zníženú známku zo správania.",
            "Poslať študenta von z triedy."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Ak je pedagóg svedkom poškodzovania školského majetku zo strany žiaka / žiakov, čo môže vykonať?",
            Spravne = new List<string>
        {
            "Oboznámiť rodičov so situáciou a vyžadovať finančné nahradenie škody."
        },
            Nespravne = new List<string>()
        {
            "Udeliť študentovi poznámku.",
            "Iba študenta upozorniť a ďalej ignorovať jeho správanie.",
            "Požadovať od študenta okamžité finančné nahradenie škody."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Ako by ste poskytli prvú pomoc v prípade, že študent dostane epileptický záchvat počas vyučovania?",
            Spravne = new List<string>
        {
            "Podložiť mu hlavu niečím mäkkým a snažiť sa obmedziť jeho pohyby."
        },
            Nespravne = new List<string>()
        {
            "Dať mu do úsť kolík, aby sa neudusil.",
            "Okamžite zavolať sanitku.",
            "Snažiť sa nájsť niekoho, kto vie poskytnúť prvú pomoc."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Vyberte postup úkonov  ako treba postupovať v prípade, že je v škole vyhlásený požiar a je nutná evakuácia. ",
            Spravne = new List<string>
        {
            "Okamžite dostať študentov z budovy a zapnúť požiarny alarm."
        },
            Nespravne = new List<string>()
        {
            "Dostať študentov z budovy a čakať na hasičov.",
            "Zapnúť požiarny alarm a čakať na hasičov.",
            "Zapnúť požiarny alarm a odísť z budovy školy."
        }
        };
        subor.Otazky.Add(otazky);

        otazky = new Otazky
        {
            Otazka = "Je vhodnejšie ukončiť hádku medzi žiakmi, ktorá vznikla na základe konverzácie, alebo usmerňovať a koordinovať diskusiu ďalej? ",
            Spravne = new List<string>
        {
            "Zvážiť druh hádky a prípadne ju koordinovať ďalej."
        },
            Nespravne = new List<string>()
        {
            "Usmerňovať a koordinovať konverzáciu ďalej.",
            "Ukončiť hádku.",
            "Ignorovať situáciu."
        }
        };
        subor.Otazky.Add(otazky);

        Subor.Add(subor);

        #endregion

    }

    #endregion

}
