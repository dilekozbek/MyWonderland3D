using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RemoveUndewaterTrees))]
public class RemoveUnderwaterTreesEditor : Editor
{
   public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        RemoveUndewaterTrees underwaterTreesScript = (RemoveUndewaterTrees)target;

        if (GUILayout.Button("Remove UnderWater Trees"))
        {
            underwaterTreesScript.RemoveTreesUnderWater();
        }
    }
}
