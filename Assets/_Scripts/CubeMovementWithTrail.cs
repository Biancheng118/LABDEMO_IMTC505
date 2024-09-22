using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementWithTrail : MonoBehaviour
{
    public float moveSpeed = 5f; // 控制移动速度
    public GameObject trailPrefab; // 拖入小球预制体
    private float trailLifetime = 5f; // 小球存在的时间
    public float shootForce = 10f; // 发射的力度

    void Update()
    {
        // 移动逻辑，使用WASD或箭头键
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, moveZ));

        // 按下C键发射小球
        if (Input.GetKeyDown(KeyCode.C))
        {
            ShootTrail();
        }
    }

    // 发射小球
    void ShootTrail()
    {
        // 实例化小球在立方体的位置
        GameObject trailSphere = Instantiate(trailPrefab, transform.position, Quaternion.identity);
        
        // 设置随机颜色
        trailSphere.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);

        // 给小球一个向前的力，模拟发射
        Rigidbody rb = trailSphere.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(transform.forward * shootForce, ForceMode.Impulse);
        }

        // 5秒后销毁小球
        Destroy(trailSphere, trailLifetime);
    }
}


