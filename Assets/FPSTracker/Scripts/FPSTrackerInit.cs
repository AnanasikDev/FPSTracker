using UnityEngine;
using UnityEditor;

public class FPSTrackerInit
{
    [MenuItem("Tools/Fps Tracker/Initialization")]
    static void Init()
    {
        GameObject handler = new GameObject();
        handler.AddComponent(typeof(FPSTracker));
    }
}
