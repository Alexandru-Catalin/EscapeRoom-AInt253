using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTeleporter : MonoBehaviour {

    public Transform Player;
    public Transform reciever;

    private bool playerIsOverlapping = false;
	
	// Update is called once per frame
	void Update () {
        if (playerIsOverlapping)
        {
            Vector3 portalToPlayer = Player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            if(dotProduct < 0f)
            {
                //Teleport him!
                float rotationDiff = Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 180;
                Player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                Player.position = reciever.position + positionOffset;

                playerIsOverlapping = false;
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // if player z position is behind our door,
            // return

            // else, do this
            playerIsOverlapping = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }
}
