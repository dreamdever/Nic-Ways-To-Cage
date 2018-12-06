using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneGameController : MonoBehaviour {

    public GameObject studentsList;
    Student[] students;
    public Timer timer;
    public Text result;
    int catched;
    int triggered;
    float time;
    public float countdown;
    // Use this for initialization
    void Start()
    {
        students = studentsList.GetComponentsInChildren<Student>();
        time = Time.time;
        timer.SetTimer(countdown);
        timer.StartTimer();
        triggered = 0;
        catched = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.IsRunning())
        {
            float randInterval = Random.Range(0.5f, 3f);
            if (Time.time - time > randInterval)
            {
                TriggerStudent();
                triggered++;
            }
        } else
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
        students[randStudent].OnCaught.AddListener(()=> { catched++; });
    }

    void OnGameOver()
    {
        result.text = "Získal si " + catched + " z " + triggered + " bodov";
    }
}
