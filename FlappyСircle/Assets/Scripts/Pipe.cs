using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float spped = 1.2f;

    void Update()
    {
        transform.position += Vector3.left * spped * Time.deltaTime;
    }
}
