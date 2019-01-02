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
    }

    void OnGameOver()
    {
        timer.SetTimer(0);
        this.gameover = true;
        result.text = "Získal si " + catched + " z " + triggered + " bodov";
        resultPanel.SetActive(true);

    }
}
