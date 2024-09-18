using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mover : MonoBehaviour
{
    public Vector3 TargetPosition;
    public float speed = 0.5f; // 可以调整这个值来控制速度
    // Start is called before the first frame update
    void Start()
    {
       TargetPosition = new Vector3(0,0,0);
       
    }

    // Update is called once per frame
    void Update()
    {
        TargetPosition = TargetPosition + new Vector3(1,0,0) * speed * Time.deltaTime;
        this.gameObject.transform.position = TargetPosition;
    }
}
