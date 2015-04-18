using UnityEngine;
using System.Collections;
using UnityEditor;

public class DebugFog : EditorWindow {

    [MenuItem ("Debug Settings/Toggle Fog")]
    public static void ToggleFog()
    {
        if (RenderSettings.fog == true)
            RenderSettings.fog = false;
        else
            RenderSettings.fog = true;

    }
}
