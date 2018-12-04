using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{

    characterController cc;
    [SerializeField]
    private AudioSource sound;

    // Use this for initialization
    void Start()
    {

        cc = GetComponent<characterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical")) 
        {
            sound.Play();
        }
        else if (!Input.GetButton("Horizontal") && !Input.GetButton("Vertical") && sound.isPlaying)
        {
            sound.Stop();
        }

        if (GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.8f, 1);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
        }

    }
}
