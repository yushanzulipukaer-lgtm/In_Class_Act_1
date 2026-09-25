using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerFactory : MonoBehaviour
{
    public abstract PlayerTrigger Create(Vector3 position);
}
