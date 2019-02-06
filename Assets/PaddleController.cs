using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float m_speed = 10f;
    Rigidbody2D m_rb;
    
    // Use this for initialization
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 入力を受け取る
        float h = Input.GetAxis("Horizontal");
        // 入力に応じてパドルを動かす
        m_rb.velocity = Vector2.right * h * m_speed;
    }
}
