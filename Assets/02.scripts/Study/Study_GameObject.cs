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
        obj.name = "���� ĳ����";
        Transform objTf = obj.transform;
        int count = objTf.childCount;
        
        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {count}");
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(count - 1).name}");
    }

}
