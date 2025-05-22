using Unity.Android.Gradle;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject Obj;

    public Mesh msh;
    public Material mat;
    void Start()
    {

        Obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        CreateCube("Hellow World");
        CreateCube();

        //CreateCube();
    }
    public void CreateCube(string name = "Cube")
    {
        Obj = new GameObject(name);

        Obj.AddComponent<MeshFilter>();
        Obj.GetComponent<MeshFilter>().mesh = msh;
        Obj.AddComponent<MeshRenderer>();
        Obj.GetComponent<MeshRenderer>().material = mat;
        Obj.AddComponent<BoxCollider>();

    }
}
