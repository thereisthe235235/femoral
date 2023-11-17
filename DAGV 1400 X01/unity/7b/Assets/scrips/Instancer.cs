using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Instancer : ScriptableObject
{

    public GameObject prefab;
    private int num;
    public void CreatInstance()
    {
        Instantiate(prefab);
    }
    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);

    }
    
    public void CreatInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3DList)
        {
        Instantiate(prefab, t.value, Quaternion.identity);
        }

    }
    
    public void CreatInstanceFromListcounting(Vector3DataList obj)
        {
            Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
            num++;
            if (num == obj.vector3DList.Count)
            {
                num = 0;

            }
        }
         
         public void CreatInstanceListRandomly(Vector3DataList obj)
        {
            num = Random.Range(0, obj.vector3DList.Count -1);
            Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);

        }
}
