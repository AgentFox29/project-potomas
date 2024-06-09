using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    // Currently just holds all the values that the player will eventually use (when i code it in)
    public float baseHealth = 100;
    public float healthPercent = 1;
    public float finalMaxHealth = 0;
    public float currentHealth = 0;

    public float baseAttack = 100;
    public float attackPercent = 1;
    public float finalAttack = 0;

    public float critRate = 5;
    public float critDamage = 1.5f;

    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Awake()
    {
        finalMaxHealth = baseHealth * healthPercent;
        finalAttack = baseAttack * attackPercent;
        currentHealth = finalMaxHealth * healthPercent;
    }

    void FixedUpdate()
    {
        finalMaxHealth = baseHealth * healthPercent;
        finalAttack = baseAttack * attackPercent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void UpdateStats()
    {
    }
}
