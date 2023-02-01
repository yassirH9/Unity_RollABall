using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchoLogica : MonoBehaviour
{
    public GameObject pincho;
    public float spawnTime = 5f;

    void Start()
    {
        InvokeRepeating("ToggleObject", 0f, spawnTime);
    }

    void ToggleObject()
    {
        pincho.SetActive(!pincho.activeSelf);
    }
}
