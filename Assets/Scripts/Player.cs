using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5;

    [SerializeField]
    private float _backSpeed = 3;

    [SerializeField]
    private float _rotateSpeed = 90;

    private void Update()
    {
        float direction = Input.GetAxis("Vertical");
        float v;
        float h;

        if (direction > 0)
        {
            v = direction * _speed * Time.deltaTime;
            h = Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime * -1;
        }
        else if (direction < 0)
        {
            v = direction * _backSpeed * Time.deltaTime;
            h = Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime * 1;
        }
        else
        {
            v = 0;
            h = 0;
        }

        Vector3 vertical = transform.TransformDirection(Vector3.up);
        transform.localPosition += vertical * v;
        transform.Rotate(new Vector3(0, 0, h));
    }
}
