using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerLossLife : MonoBehaviour
{
    public int damage;
    private int amount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            other.GetComponent<PlayerStats>().TakeDamage(damage);
           
        }
    } 
}
