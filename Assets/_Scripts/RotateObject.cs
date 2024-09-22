using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 0.01f; // 非常缓慢的旋转速度

    void Update()
    {
        // 以非常缓慢的速度围绕x轴旋转
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}



