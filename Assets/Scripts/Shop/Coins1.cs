using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            CoinText.Coin += 2;
            PlayerPrefs.SetInt("Coins", CoinText.Coin);
            Destroy(gameObject);
        }
    }
}
