using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private bool m_isQuitting;
    private bool m_isLaunched = false;

    private void OnEnable()
    {
        EventBus.StartListening("Launch", LaunchRocket);
        EventBus.StartListening("Reset", ResetRocket);
    }

    private void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Launch", LaunchRocket);
        }
    }

    public void LaunchRocket()
    {
        if (m_isLaunched == false)
        {
            m_isLaunched = true;
            Debug.Log("Event recieved: Rocket launched!");
        }
    }

    public void ResetRocket()
    {
        m_isLaunched = false;
        Debug.Log("Event recieved: rocket reset!");
    }
}
