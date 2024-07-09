using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torsion : MonoBehaviour
{
    [SerializeField] float _speed;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 1 * _speed * Time.deltaTime, 0));
    }
}
