using UnityEngine;

public class ParticleSystemControllerWindow : MonoBehaviour
{
    ParticleSystem system
    {
        get
        {
            if (_CachedSystem == null)
                _CachedSystem = GetComponent<ParticleSystem>();
            return _CachedSystem;
        }
    }
    private ParticleSystem _CachedSystem;

    public Rect windowRect = new Rect(0, 0, 300, 120);

    public bool includeChildren = true;

    void OnGUI()
    {
        windowRect = GUI.Window("ParticleController".GetHashCode(), windowRect, DrawWindowContents, system.name);
    }

    void DrawWindowContents(int windowId)
    {
        if (system)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Toggle(system.isPlaying, "Playing");
            GUILayout.Toggle(system.isEmitting, "Emitting");
            GUILayout.Toggle(system.isPaused, "Paused");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Play"))
                system.Play(includeChildren);
            if (GUILayout.Button("Pause"))
                system.Pause(includeChildren);
            if (GUILayout.Button("Stop Emitting"))
                system.Stop(includeChildren, ParticleSystemStopBehavior.StopEmitting);
            if (GUILayout.Button("Stop & Clear"))
                system.Stop(includeChildren, ParticleSystemStopBehavior.StopEmittingAndClear);
            GUILayout.EndHorizontal();

            includeChildren = GUILayout.Toggle(includeChildren, "Include Children");

            GUILayout.BeginHorizontal();
            GUILayout.Label("Time(" + system.time + ")");
            GUILayout.Label("Particle Count(" + system.particleCount + ")");
            GUILayout.EndHorizontal();
        }
        else
            GUILayout.Label("No Particle System found");

        GUI.DragWindow();
    }
}