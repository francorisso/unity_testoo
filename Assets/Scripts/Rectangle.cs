using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Rectangle : Square
{
    private void Awake()
    {
        Speed = -1f;
    }

    protected void MoveUp()
    {
        transform.position += Vector3.up * Time.deltaTime * Speed;
    }
}
