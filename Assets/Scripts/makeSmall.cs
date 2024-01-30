using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeSmall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGameSizeChange(float value)
    {
        gameObject.transform.localScale = new Vector3(value, value, 0);
    }
}
