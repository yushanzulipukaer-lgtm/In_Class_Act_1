using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private TextMeshProUGUI winText;
    [SerializeField] private TextMeshProUGUI loseText;

    private bool gameEnded = false;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        winText.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);
    }

    public void WinGame()
    {
        if (gameEnded)
            return;

        gameEnded = true;

        winText.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        if (gameEnded)
            return;

        gameEnded = true;

        loseText.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }
}