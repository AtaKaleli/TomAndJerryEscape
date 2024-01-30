using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDog : MonoBehaviour
{
    

    private void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy(gameObject, 2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Destroy(gameObject);
        
       
    }
}
