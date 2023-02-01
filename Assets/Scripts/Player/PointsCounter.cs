using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public int coinCount = 0;
    //public TextMeshPro coinCountText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            //coinCountText.text = "Coins: " + coinCount;

            other.gameObject.SetActive(false);
        }
    }
}
