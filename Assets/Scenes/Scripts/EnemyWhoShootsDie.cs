using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyWhoShootsDie : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("BulletTag"))
		{
			Destroy(gameObject);
			Destroy(other.gameObject);
		}
	}
}
