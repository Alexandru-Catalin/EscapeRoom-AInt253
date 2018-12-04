using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpening : MonoBehaviour {

    private Animator anim;
    private bool inRange;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (inRange)
        {
            if (!anim.GetBool("Open"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    anim.SetBool("Open", true);
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    anim.SetBool("Open", false);
                }
            }
        }
	}

    private void OnTriggerEnter(Collider collider)
    {
        inRange = true;
    }

    private void OnTriggerExit(Collider collider)
    {
        inRange = false;
    }
}
