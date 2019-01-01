using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Student : MonoBehaviour {

    public string animationName;
    protected int triggered = 0;
    protected int caught = 0;
    protected Animator animator;
    protected AudioSource audioData;
    public UnityEvent OnCaught = new UnityEvent();

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
    }

    protected void OnMouseOver()
    {
        
        if (CheckAnimationState(animationName))
        {
            animator.ResetTrigger(animationName);
            OnCaught.Invoke();
        }
    }

    protected virtual bool CheckAnimationState(string name)
    {
        return Input.GetMouseButtonDown(0) && animator.GetCurrentAnimatorStateInfo(0).IsName(name);
    }

    protected void AnimationAudio() {
        audioData.Play();
    }
    
}
