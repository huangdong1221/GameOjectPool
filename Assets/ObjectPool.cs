using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    //创建集合 作为对象池保存对象
    public Queue<GameObject> objects = new Queue<GameObject>();
    //单例
    private static ObjectPool instance;
    public static ObjectPool Instance()
    {
        if (instance == null)
        {
            instance = new GameObject("ShellPool").AddComponent<ObjectPool>();
        }
        return instance;
    }

    //从对象池取出对象
    public GameObject GetObjectsInPool(GameObject target)
    {
        if (objects.Count == 0)
        {
            //如果队列为空，就生成一个新的对象
            return Instantiate(target, Vector3.zero, Quaternion.identity) as GameObject;
        }
        else
        {
            //如果队列中有对象，那么取出，并显示。
            GameObject go = objects.Dequeue();

            go.SetActive(true);

            return go;
        }
    }

    //存对象到对象池
    public void PutInPool(GameObject target)
    {
        target.SetActive(false);

        objects.Enqueue(target);
    }
    
}
