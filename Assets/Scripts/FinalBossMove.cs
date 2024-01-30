using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBossMove : MonoBehaviour
{

    public float _speed = 8;
    public MouseController _mouse;

    private void Start()
    {
        Destroy(gameObject,45);
    }


    private void FixedUpdate()
    {
        transform.position += Vector3.left * Time.deltaTime * _speed;
    }

    private void Update()
    {
        if (_mouse._isGameEnd)
        {
            Destroy(gameObject);
        }
    }

}
