using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject shellPrefab;

    public void Start()
    {
        shellPrefab = Resources.Load("Prefabs/Sphere") as GameObject;
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ObjectPool.Instance().GetObjectsInPool(shellPrefab);
        }
    }
}
