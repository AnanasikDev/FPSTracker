using UnityEngine;
using System;

public class FPSTracker : MonoBehaviour
{
    public static float CurrentFPS { get; private set; }

    private void Update()
    {
        CurrentFPS = 1f / Time.deltaTime;
    }
}
