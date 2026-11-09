using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    private void OnTriggerEnter(Collider other)
    {
         if( other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins = coins + 1;
            Debug.Log("Coins: " + coins);
        }
    }
}
