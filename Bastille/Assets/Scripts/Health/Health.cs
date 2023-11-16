using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth {  get; private set; }
    Rigidbody2D rb;
    
    private void Awake()
    {
        currentHealth = startingHealth;
        enemyAI.takeDmg.AddListener(TakeDamage);
    }

    public void TakeDamage(float _damage, Vector2 direction)
    {
        rb.AddForce(direction * 10f, ForceMode2D.Impulse);
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth < 0) 
        { 
            //dmg
        }
        else
        {
            //death
        }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
