using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : PlayerTrigger
{
    protected override void OnPlayerEnter()
    {
        GameManager.Instance.LoseGame();
    }  

}