using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    protected virtual void MoveLeft()
    {
        transform.position += Vector3.left * Time.deltaTime;
    }

    protected virtual void MoveRight()
    {
        transform.position += Vector3.right * Time.deltaTime;
    }
}
