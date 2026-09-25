using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardFactory : TriggerFactory
{
    [SerializeField] private Hazard hazardPrefab;

    public override PlayerTrigger Create(Vector3 position)
    {
        return Instantiate(hazardPrefab, position, Quaternion.identity);
    }
}
