using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoorControl : MonoBehaviour
{
    public PlayerController playerController;
    public GameObject leftDoor;
    public GameObject rightDoor;
    public Vector3 doorMovement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (playerController.keyCollected)
            {
                Debug.Log("correct");
                leftDoor.transform.position = leftDoor.transform.position + doorMovement;
                rightDoor.transform.position = rightDoor.transform.position - doorMovement;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        leftDoor.transform.position = leftDoor.transform.position - doorMovement;
        rightDoor.transform.position = rightDoor.transform.position + doorMovement;
    }
}
