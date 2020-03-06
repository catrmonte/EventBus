using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firework : MonoBehaviour
{
    private bool m_isQuitting;

    private void OnEnable()
    {
        EventBus.StartListening("Light", LightFirework);
    }

    private void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Light", LightFirework);
        }
    }

    void LightFirework()
    {
        Debug.Log("Received an event: Lighting Firework!");
    }
}
