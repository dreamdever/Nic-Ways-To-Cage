using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour {

    protected string animationName;
    protected int triggered = 0;
    protected int caught = 0;
    protected Animator animator;
    protected AudioSource audioData;
    // Use this for initialization
    protected void Start () {
        animator = gameObject.GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();
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

    protected void OnMouseOver()
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
