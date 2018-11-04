using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public int coins = 0;
    public Text coinPoint;

    void OnTriggerEnter(Collider other)
    {
        // Checking gameobjects with tag 'coin'         // coin == diamonds
        if (other.tag == "Coin")
        {
            // Destroying diamonds
            Destroy(other.gameObject);
            coins++;
            coinPoint.text = coins.ToString();
        }
    }
}
