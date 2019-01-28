using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneGameController : MonoBehaviour {

    public GameObject studentsList;
    Student[] students;
    public Timer timer;
    public Text result;
    private bool gameover = false;
    int catched;
    int triggered;
    float time;
    public float countdown;
    public GameObject resultPanel;
    public Text tip;

    private readonly string[] tips = {
        "Pokiaľ sa študent hrá s telefónom počas vyučovania a nereaguje na upozornenie, pedagóg môže zobrať telefón do konca vyučovania. V prípade, že sa daná situácia vyskytuje pravidelne, je vhodné dohodnúť si pravidlá s triedou. ",
        "Pokiaľ študent kreslí nevhodné obrázky a nereaguje na upozornenie, je potrebné dohodnúť si individuálny pohovor s ním a jeho rodičmi. ",
        "Pokiaľ študent ruší na vyučovaní, treba zvážiť možnosti, prečo študent vyrušuje (psychická podstata problému, hyperaktivita). Pokiaľ má študent spravenú úlohu zadanú učiteľom a napriek tomu vyrušuje, treba mu zadať viac práce.",
        "Pokiaľ má študent nevhodné poznámky a nereaguje na upozornenie, je potrebné dohodnúť si individuálny pohovor s rodičmi a zvážiť výchovného poradcu.  ",
        "Pokiaľ študent spí na vyučovaní, je potrebné uskutočniť individuálny rozhovor, či sa niečo nedeje v domácnosti študenta, čo mu bráni v spánku, alebo či študent neberie lieky spôsobujúce utlmenie a ospalosť.",
        "Pokiaľ je študent opitý, pedagóg musí zavolať rodičom, nech si vyzdvihnú študenta zo školy. Treba zvážiť zníženú známku zo správania. ",
        "Pokiaľ žiak fyzicky napadne spolužiaka, pedagóg musí dostať študentov od seba a následne zavolať rodičom oboch z nich. Treba zvážiť zníženú známku zo správania.",
        "Pokiaľ sú študenti prichytení, ako fajčia, je potrebné zavolať rodičom, oboznámiť ich so situáciou a zvážiť výchovného poradcu.",
        "Pokiaľ sa študent správa vulgárne voči pedagógovi a nereaguje na upozornenie, je vhodné zobrať študenta k riaditeľovi a oznámiť rodičom študentove správanie. Treba zvážiť zníženú známku zo správania.",
        "Pokiaľ študent ničí školský majetok a pokračuje napriek upozorneniu, je nutné so správaním oboznámiť rodičov a požadovať finančné nahradenie škody.",
        "Pokiaľ študent dostane epileptický záchvat, pedagóg je povinný okamžite podať prvú pomoc a zabezpečiť lekársku starostlivosť.",
        "Pokiaľ v škole nastane požiar, pedagóg je povinný okamžite evakuovať študentov a okamžite spustiť požiarny alarm."

    };

    // Use this for initialization
    void Start()
    {
        resultPanel.SetActive(false);
        students = studentsList.GetComponentsInChildren<Student>();
        time = Time.time;
        timer.SetTimer(countdown);
        timer.StartTimer();
        triggered = 0;
        catched = 0;

        foreach(Student student in students)
        {
            student.OnCaught.AddListener(() => { catched++; });
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {
            OnGameOver();
        }

        if (timer.IsRunning() && !gameover)
        {
            float randInterval = Random.Range(0.5f, 5f);
            if (Time.time - time > randInterval && timer.GetTime() > 3)
            {
                TriggerStudent();
                triggered++;
            }
        } else if (!this.gameover)
        {
            OnGameOver();
        }

    }

    void TriggerStudent()
    {
        time = Time.time;

        int studentsCount = studentsList.GetComponentsInChildren<Student>().Length;

        int randStudent = Random.Range(0, studentsCount);
        
        students[randStudent].DoYourThing();
    }

    void OnGameOver()
    {
        timer.SetTimer(0);
        this.gameover = true;
        result.text = "Získal si " + catched + " z " + triggered + " bodov";
        tip.text = tips[Random.Range(0, tips.Length)];
        resultPanel.SetActive(true);

    }
}
