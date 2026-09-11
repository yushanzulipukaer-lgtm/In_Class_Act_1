using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Condition 4: Touch hazard = lose
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.LoseGame();
        }
    }
}