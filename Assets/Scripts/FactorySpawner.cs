using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySpawner : MonoBehaviour
{
    [SerializeField] private TriggerFactory factory;
    [SerializeField] private Transform spawnPoint;

    private void Start()
    {
        factory.Create(spawnPoint.position);
    }
}
