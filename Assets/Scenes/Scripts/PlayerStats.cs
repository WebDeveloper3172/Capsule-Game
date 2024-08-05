    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int maxHealth;

    [SerializeField] private int currentHealth;
    private int reserveHealth;
    private PlayerLife playerLife;
    public HealthBar healthBar;

    [SerializeField] AudioSource lostLifeSound;
    [SerializeField] AudioSource addLife;

    private void Start()
    {
        currentHealth = maxHealth;
        reserveHealth = currentHealth;
        playerLife = GetComponent<PlayerLife>();
        healthBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
        lostLifeSound.Play();
    }

    public void Heal(int amount)
    {

        if (currentHealth >= reserveHealth)
        { currentHealth = maxHealth; }
        else { currentHealth += amount; }
        healthBar.SetSlider(currentHealth);
        addLife.Play();
    }

    private bool _isDead;

    private void Update()
    {
        
        if (!_isDead && currentHealth <= 0)
        {  
            playerLife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
            playerLife.Endoflife();
            _isDead = true;
        }
    }

   

}
