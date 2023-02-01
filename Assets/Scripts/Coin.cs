using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed = 50f;
    public float oscillationSpeed = 1f;
    public float oscillationDistance = 1f;

    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
        transform.position = new Vector3(transform.position.x, startY + Mathf.Sin(Time.time * oscillationSpeed) * oscillationDistance, transform.position.z);
    }
}
