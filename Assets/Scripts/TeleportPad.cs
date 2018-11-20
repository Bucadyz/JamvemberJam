using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour {

    public float teleportx = 0.0f;
    public float teleporty = 1.0f;
    public float teleportz = 0.0f;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = new Vector3(teleportx, teleporty, teleportz);
        }      
    }
}
