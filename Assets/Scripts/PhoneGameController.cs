using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneGameController : MonoBehaviour {

    public GameObject students;
    float time;
    // Use this for initialization
    void Start()
    {
        time = Time.time;
        Student.animationName = "UsingPhone";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - time > 3)
        {
            TriggerStudent();
        }
    }

    void TriggerStudent()
    {
        time = Time.time;

        int ziaciCount = students.GetComponentsInChildren<Student>().Length;

        int ziak = Random.Range(0, ziaciCount);

        Student[] ziakovia = students.GetComponentsInChildren<Student>();
        ziakovia[ziak].DoYourThing();
    }
}
