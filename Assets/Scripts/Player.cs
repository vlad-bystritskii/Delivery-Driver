using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5;

    [SerializeField]
    private float _rotateSpeed = 90;

    private void Update()
    {
        float v = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        float h;

        if (v > 0)
        {
            h = Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime * -1;
        }
        else if (v < 0)
        {
            h = Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime * 1;
        }
        else
        {
            h = 0;
        }
        Vector3 vertical = transform.TransformDirection(Vector3.up);
        transform.localPosition += vertical * v;

        transform.Rotate(new Vector3(0, 0, h));
    }
}
