using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EditorTest 
{
    [MenuItem("Test/Test")]
    public static void Test()
    {
        var path = "Assets/DelTest";
        foreach (var guid in AssetDatabase.FindAssets("t:Prefab", new string[] { path }))
        {
            var file = AssetDatabase.GUIDToAssetPath(guid);
            var go = AssetDatabase.LoadAssetAtPath<GameObject>(file);
            foreach (var img in go.GetComponentsInChildren<Image>(true))
                GameObject.DestroyImmediate(img, true);
            EditorUtility.SetDirty(go);
        }
        AssetDatabase.SaveAssets();
    }
}
