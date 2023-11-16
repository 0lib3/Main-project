using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth {  get; private set; }
    
    private void Awake()
    {
        currentHealth = startingHealth;
        enemyAI.takeDmg.AddListener(TakeDamage);
    }

    public void TakeDamage(float _damage)
    {
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

    //Debug
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            TakeDamage(1);
        }
    }
}
