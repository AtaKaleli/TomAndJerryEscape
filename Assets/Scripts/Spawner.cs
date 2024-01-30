using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject _enemyMoving;
    private float _height = 6f;
    public MouseController _mouse;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (!_mouse._isDead)
        {
            Instantiate(_enemyMoving, new Vector3(22, Random.Range(-_height, _height), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
        
    }


}
