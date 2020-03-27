using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    Transform trf;

    public void OnEnable()
    {
        trf = GameObject.Find("GameObjectPool").transform;

        this.transform.position = trf.position;

        StartCoroutine(EnQueue(2f));
    }

    public void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * 200);
    }

    IEnumerator EnQueue(float time)
    {
        yield return new WaitForSeconds(time);
        ObjectPool.Instance().PutInPool(this.gameObject);
    }
}
