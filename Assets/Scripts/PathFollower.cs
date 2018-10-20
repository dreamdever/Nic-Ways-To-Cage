using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LoopType
{
    Single, Infinite
}

public class PathFollower : MonoBehaviour {

    public GameObject follower;
    public float speed;
    public LoopType Loop;

    Node [] pathNode;
    static Vector3 currentPosition;
    int currentNode;
    bool movingForward = true;

	// Use this for initialization
	void Start () {
        pathNode = GetComponentsInChildren<Node>();
        CheckNode();
	}

    void CheckNode()
    {
        currentPosition = pathNode[currentNode].transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        
		if (follower.transform.position != currentPosition )
        {
            follower.transform.position = Vector3.MoveTowards(follower.transform.position, currentPosition, Time.deltaTime * speed);
        }
        else
        {
            if (movingForward)
            {
                if (currentNode < pathNode.Length - 1)
                {
                    currentNode++;
                }
                else
                {
                    movingForward = Loop == LoopType.Infinite ? false : true;
                }
            }
            else
            {
                if (currentNode > 0)
                {
                    currentNode--;
                }
                else
                {
                    movingForward = Loop == LoopType.Infinite ? true : false;
                }
            }

            CheckNode();

        }
	}
}
