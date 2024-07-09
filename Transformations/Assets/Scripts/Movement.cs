using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _growthSpeed;
    private Vector3 _startDirection;

    private void Start()
    {
        _startDirection = new Vector3(transform.localPosition.normalized.x, 0, 0);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 1 * _rotationSpeed * Time.deltaTime, 0));
        transform.Translate(_startDirection * _moveSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_growthSpeed * Time.deltaTime, _growthSpeed * Time.deltaTime, _growthSpeed * Time.deltaTime);
    }
}
