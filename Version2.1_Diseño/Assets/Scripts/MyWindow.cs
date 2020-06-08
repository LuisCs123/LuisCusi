using System.Collections;
using UnityEditor;
using UnityEngine;

public class MyWindow : EditorWindow
{  
    public enum PILE_TYPE { increase, decrease }
    /*private System.Enum state;*/
    public PILE_TYPE state;

    private Vector3 size = Vector3.one;
    private int separation = 0;

    [MenuItem("Luis/PileGenerator")]
    public static void ShowWindow() => GetWindow<MyWindow>("PILEGENERATOR");
    private static GameObject[] prefabs = null;

    [SerializeField] private string search = string.Empty;
    [SerializeField] private GameObject obj = null;

    private void LoadObject()
    {
        string path = "Assets/Prefabs";
        UnityEngine.Object obj = AssetDatabase.LoadAssetAtPath(path, typeof(UnityEngine.Object));

        Debug.Log("LA RUTA ES" + path);

        foreach (string file in System.IO.Directory.GetFiles(path))
        {
            Debug.Log("NOMBRE DEL PREFAB" + file);
        }
   
    }

   /* private static void getPrefabs()
    {
       
        string[] search_results = System.IO.Directory.GetFiles("Assets/Prefabs/", "*.prefab", System.IO.SearchOption.AllDirectories);

        for (int i = 0; i < search_results.Length; i++)
        {
            Object prefab = null;
            prefab = AssetDatabase.LoadAssetAtPath(search_results[i], typeof(GameObject));
            prefabs[i] = prefab as GameObject;

            Debug.Log(prefabs[i].name + " " + prefabs.Length);
        }
    }*/
    
    private void OnGUI()
    {
        search = EditorGUILayout.TextField("Search prefab", search);

        GUILayout.Label("SELECT PREFAB", EditorStyles.boldLabel);
        obj = EditorGUILayout.ObjectField(obj, typeof(GameObject), false) as GameObject;

        /*state = EditorGUILayout.EnumFlagsField("Pile length", Enum.GetValues(typeof(PILE_TYPE)));*/
        state = (PILE_TYPE)EditorGUILayout.EnumPopup("Pile length", state);
        size = EditorGUILayout.Vector3Field("Size of gizmo", size);
        separation = EditorGUILayout.IntField("Distance of objects", separation);
        
        if (GUILayout.Button("Show assets list"))
        {
            Debug.Log("TEST DONE");
            /*getPrefabs();*/
            LoadObject();
            /*getPrefabs();*/        
        }

        if (GUILayout.Button("Generate gizmo area"))
        {
            

        }

        if (GUILayout.Button("Generate prefabs"))
        {


        }

        if (GUILayout.Button("Increase/Decrease pile"))
        {


        }
        if (GUILayout.Button("Clean"))
        {
            

        }

    }
    
    
}
