using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D m_rb;
    public Vector2 m_startDir = new Vector2(1f, 1f);
    public float m_startPower = 10f;

    // Use this for initialization
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        // ボールを動かすために力を加える
        m_rb.AddForce(m_startDir.normalized * m_startPower, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
