using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Square : Shape
{
    private float m_speed = 2f;
    // ENCAPSULATION
    public float Speed
    {
        get { return m_speed; }

        set
        {
            if (value < 0f)
            {
                Debug.LogError("speed variable has to be >0");
                return;
            }

            m_speed = value;
        }
    }

    // POLYMORPHISM
    protected override void MoveLeft()
    {
        transform.position += Vector3.left * Time.deltaTime * Speed;
    }

    protected override void MoveRight()
    {
        transform.position += Vector3.right * Time.deltaTime * Speed;
    }
}
