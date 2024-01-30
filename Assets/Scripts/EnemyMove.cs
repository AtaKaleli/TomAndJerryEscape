using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float _speed = 8;

    private void Start()
    {
        Destroy(gameObject, 8);
    }


    private void FixedUpdate()
    {
        transform.position += Vector3.left * Time.deltaTime * _speed;
    }

}
