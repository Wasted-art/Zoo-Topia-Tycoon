using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CustomEditor(typeof(TileMap))]
public class TileMapInspecter : Editor
{

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        DrawDefaultInspector();
        if (GUILayout.Button("Regenerate"))
        {
            TileMap tileMap = (TileMap)target;
            tileMap.BuildMesh();
        }
    }
}