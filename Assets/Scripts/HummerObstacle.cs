using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HummerObstacle : MonoBehaviour
{
    public GameObject hummer;
    public float rotationSpeed = 10f;
    Transform transform;
    void Start()
    {
        transform = hummer.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(transform.position, Vector3.fwd, rotationSpeed * Time.deltaTime);
        float xRotation = Mathf.Sin(Time.time * rotationSpeed) * 90;
        transform.localRotation = Quaternion.Euler(0, 0, xRotation);
    }
}
