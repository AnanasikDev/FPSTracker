using UnityEngine;
using UnityEditor;

public class FPSTrackerEditor : EditorWindow
{
    public Color TextColor = new Color(0.975f, 1f, 1f, 1f);

    [MenuItem("Tools/Fps Tracker/Fps Tracker Window")]
    static void CreateWindow()
    {
        FPSTrackerEditor window = (FPSTrackerEditor)EditorWindow.GetWindow(typeof(FPSTrackerEditor));
        window.Show();
        GUIContent title = new GUIContent();
        title.text = "FPS Tracker Tool";
        window.titleContent = title;
    }
    private void DrawUI()
    {
        GUILayout.BeginVertical("box");

        GUIStyle style = new GUIStyle();
        style.fontSize = 20;
        GUI.contentColor = Color.white;
        GUI.color = Color.white;

        GUILayout.Label($"Current FPS : {FPSTracker.CurrentFPS}", style);

        GUI.contentColor = Color.white;

        GUILayout.EndVertical();

        Repaint();
    }
    public void OnGUI()
    {
        DrawUI();
    }
}
