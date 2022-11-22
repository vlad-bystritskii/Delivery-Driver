using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3;
    [SerializeField]
    private float _rotateSpeed = 3;
    private void Update()
    {
        Vector3 direction = new Vector3(0, Input.GetAxis("Vertical"), 0);
        transform.Translate(direction * _speed * Time.deltaTime);
        Vector3 rotation = new Vector3(0, 0, -1 * Input.GetAxis("Horizontal"));
        transform.Rotate(rotation * _rotateSpeed * Time.deltaTime);
    }
}
