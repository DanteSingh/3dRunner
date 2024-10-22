using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public controller csMovement;
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle")
        {csMovement.enabled = false;
        FindObjectOfType<GameManager>().endGame();
        }
    }
}
