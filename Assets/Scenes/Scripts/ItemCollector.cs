using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] TextMeshProUGUI coinsText;

    [SerializeField] TextMeshProUGUI finalcoinsforGameOverText;
    [SerializeField] TextMeshProUGUI finalcoinsforFinishLevelText;

    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins : " + coins + "/8";
            collectionSound.Play();
            finalcoinsforGameOverText.text = "COINS : " + coins + "/8";
            finalcoinsforFinishLevelText.text = "COINS : " + coins + "/8";
        }
    }
}
