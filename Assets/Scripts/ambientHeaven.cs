using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambientHeaven : MonoBehaviour {

    [SerializeField]
    private AudioSource sound;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    { 
        if(other.tag == "Player")
        {
            sound.Play();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            sound.Stop();
        }
    }
}
