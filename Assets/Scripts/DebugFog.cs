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
    [MenuItem ("Debug Settings/Toggle Walls")]
    public static void ToggleWalls()
    {
        GameObject[] wallCollection;
        wallCollection = GameObject.FindGameObjectsWithTag("Wall");
        foreach (GameObject wall in wallCollection)
        {
            wall.GetComponent<Renderer>().enabled = !wall.GetComponent<Renderer>().enabled;
        }
    }
}
