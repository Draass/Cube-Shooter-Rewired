using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy: MonoBehaviour 
{

    public EnemyData data;

    private float MaxHealth 
    {
        get
        {
            Debug.Log("Getting health");
            if (data == null)
                Debug.LogError("Data is not found. Have you added data to EnemyData field;");

            if (data.maxHealth <= 0)
                Debug.LogError("Health can not be lower than 0!");

            return data.maxHealth;
        }
    }

    public float maxHealth;
    public float currenthealth;

    public float maxSpeed;
    public float currentSpeed;

    public virtual void Awake()
    {
        InitializeParameters();
    }

    public virtual void InitializeParameters()
    {
        maxHealth = MaxHealth;
        currenthealth = maxHealth;
    }

    public virtual void TakeDamage(float damage)
    {
        currenthealth -= damage;
    }



}
