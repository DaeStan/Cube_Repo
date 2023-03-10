using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
