using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfimaGames.LowPolyShooterPack;


public class Health : MonoBehaviour
{

    public float maxHealth;
    //[HideInInspector]
    public float currentHealth;
    Ragdoll ragdoll;
    UIHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        ragdoll = GetComponent<Ragdoll>();
        healthBar = GetComponentInChildren<UIHealthBar>();
        currentHealth = maxHealth;

        var rigidBodies = GetComponentsInChildren<Rigidbody>();
        foreach (var rigidBody in rigidBodies)
        {
            HitBox hitBox = rigidBody.gameObject.AddComponent<HitBox>();
            hitBox.health = this;
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetHealthBarPercentage(currentHealth / maxHealth);
        if (currentHealth <= 0.0f)
        {
            Die();
        }
    }

    private void Die()
    {
        StartCoroutine(Death());
    }

    IEnumerator Death()
    {
        ragdoll.ActivateRagdoll();
        healthBar.gameObject.SetActive(false);
        yield return new WaitForSeconds(1);
        GameObject.Find("Player").GetComponent<Scoring>().AddScore(10);
        Destroy(gameObject);
    }
}