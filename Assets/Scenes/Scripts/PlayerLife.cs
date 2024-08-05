using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour  
{
    [SerializeField] AudioSource deathSound;

    [SerializeField] private GameObject playerGun;

    [SerializeField] private GameObject playerBulletOrigin;
    [SerializeField] private GameObject gameOverPupUp;

    bool dead = false;

    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
           Die();
        }
    }

    public void Endoflife()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        playerGun.GetComponent<MeshRenderer>().enabled = false;
        Die();
    }

    public void PopUpAfterDie()
    {
        gameOverPupUp.SetActive(true);
    }

    public void Die()
    {
        dead = true;
        deathSound.Play();
        Invoke(nameof(PopUpAfterDie), 1.3f);
        playerBulletOrigin.GetComponent<ShootBullet>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
      
    }
}

