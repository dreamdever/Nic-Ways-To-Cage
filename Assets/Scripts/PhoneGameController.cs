using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneGameController : MonoBehaviour {

    public GameObject ziaci;
    float time;
    // Use this for initialization
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time.ToString() + "   " + time.ToString());
        if (Time.time - time > 3)
        {
            TriggerZiak();
        }
    }

    void TriggerZiak()
    {
        time = Time.time;

        int ziaciCount = ziaci.GetComponentsInChildren<ZiakController>().Length;

        int ziak = Random.Range(0, ziaciCount);

        ZiakController[] ziakovia = ziaci.GetComponentsInChildren<ZiakController>();
        ziakovia[ziak].RobNeplechu();
    }
}
