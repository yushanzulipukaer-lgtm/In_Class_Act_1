using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFactory : TriggerFactory
{
    [SerializeField] private Goal goalPrefab;

    public override PlayerTrigger Create(Vector3 position)
    {
        return Instantiate(goalPrefab, position, Quaternion.identity);
    }
}

