﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Score>().stopScore = true;

        }        
    }

    private void OnTriggerEnter(Collider other)
    {
       
    }
}
