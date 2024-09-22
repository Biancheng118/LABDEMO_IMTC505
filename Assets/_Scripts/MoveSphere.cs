using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float jumpHeight = 2.0f; // 跳起的高度
    public float jumpSpeed = 3.0f;  // 跳起的速度
    private Vector3 originalPosition; // 记录物体的原始位置
    private bool isJumpingUp = false; // 标记物体是否正在跳起
    private bool isFallingDown = false; // 标记物体是否正在落下

    void Start()
    {
        originalPosition = transform.position; // 记录物体的初始位置
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumpingUp && !isFallingDown)
        {
            isJumpingUp = true; // 开始跳跃
        }

        if (isJumpingUp)
        {
            // 向上移动，只改变y轴
            transform.position += Vector3.up * jumpSpeed * Time.deltaTime;

            // 检查是否达到跳跃高度
            if (transform.position.y >= originalPosition.y + jumpHeight)
            {
                isJumpingUp = false; // 停止跳跃
                isFallingDown = true; // 开始下降
            }
        }

        if (isFallingDown)
        {
            // 以一半速度回到原位，只改变y轴
            float newY = transform.position.y - (jumpSpeed / 2) * Time.deltaTime;

            // 确保y轴不超过初始位置
            if (newY <= originalPosition.y)
            {
                newY = originalPosition.y; // y轴回到初始位置
                isFallingDown = false; // 停止下降
            }

            // 只改变y轴，不改变z轴
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }
}