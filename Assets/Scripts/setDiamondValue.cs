using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setDiamondValue : MonoBehaviour {

    public int coins = 0;
    public Text SetCoinValue;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coins++;
            SetCoinValue.text = coins.ToString();
        }
    }
}
