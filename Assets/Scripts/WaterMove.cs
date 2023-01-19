using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMove : MonoBehaviour
{
    void Update() 
    {
            transform.position += Vector3.up * Time.deltaTime;
    }
}
