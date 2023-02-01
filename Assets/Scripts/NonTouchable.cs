using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonTouchable : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("plater touched");
            collision.gameObject.GetComponent<Rigidbody>().GetComponent<Rigidbody>().Sleep();
            collision.gameObject.GetComponent<Transform>().position = new Vector3(0, 0, 0);
            collision.gameObject.GetComponent<Rigidbody>().GetComponent<Rigidbody>().Sleep();

        }
    }   
}
