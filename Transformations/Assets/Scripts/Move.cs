using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 _movementDirection;
    private float _speed;

    private void Start()
    {
        _movementDirection = new Vector3(0, 0, -1);
        _speed = 3;
    }

    private void Update()
    {
        transform.position += _movementDirection.normalized * _speed * Time.deltaTime;
    }
}
