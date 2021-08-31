# DeleteComponentsTest
 
## Don't save when delete component on multiple prefab

#### What happened

1. var go = Assetdatabase.LoadAssetAtPath<GameObject>(path1);
2. GameObject.DestroyImmediate(compOnGo, true);
3. EditorUtility.SetDirty(go)
4. Repeat step 1 on path2
5. Repeat step 2 on path2
6. Repeat setp 3 on path2
7. AssetDatabase.SaveAssets()
8. Show error on console: CheckConsistency: GameObject does not reference component MonoBehaviour. Fixing.
9. And only one prefab is saved correctly


#### How can we reproduce it using the example you attached

1. Check prefab on "Assets/DelTest", There are Image component in every Prefab
1. Execute menu item "Test/Test"
2. Check prefab on "Assets/DelTest", only one prefab has not Image component.
