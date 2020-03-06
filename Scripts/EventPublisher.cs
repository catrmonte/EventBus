using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        // Press S to shoot
        if (Input.GetKeyDown(KeyCode.S))
        {
            EventBus.TriggerEvent("Shoot");
        }

        // Eventually press L to launch
        if (Input.GetKeyDown(KeyCode.L))
        {
            EventBus.TriggerEvent("Launch");
        }

        // Eventually press R to reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            EventBus.TriggerEvent("Reload");
        }

        // Eventually press e to reset rocket
        if (Input.GetKeyDown(KeyCode.E))
        {
            EventBus.TriggerEvent("Reset");
        }

        // Press F to light firework
        if (Input.GetKeyDown(KeyCode.F))
        {
            EventBus.TriggerEvent("Light");
        }
    }
}
