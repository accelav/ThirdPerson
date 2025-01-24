using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    [SerializeField]
    int maxHealth = 5;
    [SerializeField]
    int currentHealth = 2;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }
    public void ModifyHealth(int amount)
    {
        if (currentHealth + amount < 0)
        {
            Debug.Log("Muerto");

        }
        else if (currentHealth + amount > maxHealth)
        {
            Debug.Log("Vida a tope");
            currentHealth = maxHealth;
        }

        else
        {
            currentHealth += amount;
            Debug.Log("Tiene " + currentHealth + " de vida");
        }

    }

    void UpdateAnimator()
    {
        animator.SetInteger("Health", currentHealth);

    }
}
