using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Student : MonoBehaviour {

    public string animationName;
    protected int triggered = 0;
    protected int caught = 0;
    protected Animator animator;
    public UnityEvent OnCaught = new UnityEvent();
    private AudioSource audioData;
    private bool inCollision = false;

    // Use this for initialization
    protected void Start () {
        animator = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(inCollision);
    }

    public virtual void DoYourThing()
    {
        Debug.Log(animationName);
        animator.SetTrigger(animationName);
    }

    protected void OnMouseOver()
    {
        
        if (CheckAnimationState(animationName) && !inCollision)
        {
            audioData.Stop();
            transform.Find("sounds/Caught").gameObject.GetComponent<AudioSource>().Play();
            animator.SetTrigger("Stop");
            OnCaught.Invoke();
        }
    }

    protected virtual bool CheckAnimationState(string name)
    {
        return Input.GetMouseButtonDown(0) && animator.GetCurrentAnimatorStateInfo(0).IsName(name);
    }

    protected void AnimationAudio() {
        audioData = transform.Find("sounds/" + animationName).gameObject.GetComponent<AudioSource>();
        audioData.Play();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "zachod")
        {
            inCollision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inCollision = false;
    }

}
