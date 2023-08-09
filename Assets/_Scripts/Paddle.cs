using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float _speed = 50f;

    [SerializeField] private int _maxX;
    [SerializeField] private int _minX;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -(_speed * Time.deltaTime);

            if (transform.position.x < _minX)
            {
                transform.position = new Vector3(_minX, transform.position.y, transform.position.z);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * (_speed * Time.deltaTime);

            if (transform.position.x > _maxX)
            {
                transform.position = new Vector3(_maxX, transform.position.y, transform.position.z);
            }
        }
    }
}
