using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    [SerializeField] PlayerController player;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.score++;
            Debug.Log(other.gameObject.tag);
        }
    }

   
}
