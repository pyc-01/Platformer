using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y+4, transform.position.z);
    }
}
