using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public PlayerController playerController;

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            playerController.keyCollected = true;
            Destroy(gameObject);
        }
    }
    
}
