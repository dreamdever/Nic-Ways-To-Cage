using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneGameController : MonoBehaviour {

    public GameObject studentsList;
    Student[] students;
    public Timer timer;
    float time;
    public float countdown;
    // Use this for initialization
    void Start()
    {
        students = studentsList.GetComponentsInChildren<Student>();
        time = Time.time;
        Student.animationName = "UsingPhone";
        timer.SetTimer(countdown);
        timer.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.IsRunning())
        {
            if (Time.time - time > 3)
            {
                TriggerStudent();
            }
        } else
        {
            for(int i = 0; i < students.Length; i++)
            {

            }
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
        Debug.Log("si v prdeli");
    }
}
