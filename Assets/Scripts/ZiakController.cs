using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZiakController : MonoBehaviour {

    Animator animator;
    AudioSource audioData;
    // Use this for initialization
    void Start () {
        animator = gameObject.GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void RobNeplechu()
    {
        animator.SetTrigger("neplecha");
    }

    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("UsingPhone"))
            {
                Debug.Log("chytil si ho");
                audioData.Play(0);
            }
        }
    }
}
