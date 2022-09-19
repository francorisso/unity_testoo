using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squares : MonoBehaviour
{
    private float m_speed = 2f;

    protected virtual void MoveLeft()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
    }

    protected virtual void MoveRight()
    {
        transform.position += Vector3.right * Time.deltaTime;
    }
}
