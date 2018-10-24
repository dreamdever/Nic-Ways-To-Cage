using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour {

    public static string animationName;
    int triggered = 0;
    int caught = 0;
    Animator animator;
    AudioSource audioData;
    // Use this for initialization
    void Start () {
        animator = gameObject.GetComponent<Animator>();
        //audioData = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public virtual void DoYourThing()
    {
        Debug.Log(animationName);
        animator.SetTrigger(animationName);
        triggered++;
    }

    private void OnMouseOver()
    {
        if (CheckAnimationState(animationName))
        {
            animator.SetTrigger("Stop");
            Debug.Log("chytil si");
            caught++;
        }
    }

    protected virtual bool CheckAnimationState(string name)
    {
        return Input.GetMouseButtonDown(0) && animator.GetCurrentAnimatorStateInfo(0).IsName(name);
    }
}
