using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject ballPrefab;
    public float fireRate = 1f;
    public float fireForce = 1000f;

    private float timeSinceLastFire = 0f;
    private Transform target;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (target == null)
            return;

        timeSinceLastFire += Time.deltaTime;

        if (timeSinceLastFire >= fireRate)
        {
            timeSinceLastFire = 0f;

            Vector3 direction = (target.position - transform.position).normalized;
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            ball.GetComponent<Rigidbody>().AddForce(direction * fireForce);
        }

        transform.LookAt(target);
    }
}
