using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : PlayerTrigger
{
    protected override void OnPlayerEnter()
    {
        GameManager.Instance.WinGame();
    }
}
