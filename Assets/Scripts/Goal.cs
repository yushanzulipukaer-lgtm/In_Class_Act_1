using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Condition 6: Reach goal = win
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.WinGame();
        }
    }
}
