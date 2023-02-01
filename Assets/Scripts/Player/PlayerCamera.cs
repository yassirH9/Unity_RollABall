using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 10.0f;
    public float angle = 40.0f;

    private void LateUpdate()
    {
        transform.position = target.position + Quaternion.AngleAxis(angle, Vector3.left) * (-Vector3.forward * distance);
        transform.LookAt(target);
    }
}
