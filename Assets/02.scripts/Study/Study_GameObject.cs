using System.Threading;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Study_GameObject : MonoBehaviour
{
    public GameObject Prefab;
    void Awake()
    {
        CreateAmongus();
    }
    public void CreateAmongus()
    {
        GameObject obj = Instantiate(Prefab);
        obj.name = "어몽어스 캐릭터";
        Transform objTf = obj.transform;
        int count = objTf.childCount;
        
        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(count - 1).name}");
    }

}
