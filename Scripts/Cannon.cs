using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private bool m_isQuitting;

    private void OnEnable()
    {
        EventBus.StartListening("Shoot", ShootCannon);
        EventBus.StartListening("Reload", ReloadCannon);
    }

    private void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Shoot", ShootCannon);
            EventBus.StopListening("Reload", ReloadCannon);
        }
    }

    void ShootCannon ()
    {
        Debug.Log("Received a shoot event: shooting cannon!");
    }

    void ReloadCannon ()
    {
        Debug.Log("Received a event: reloading cannon!");
    }
}
