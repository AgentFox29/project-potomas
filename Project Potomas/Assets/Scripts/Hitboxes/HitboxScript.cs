using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    public float attackScaling = 1f;

    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy") 
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Stats playerStats = player.GetComponent<Stats>();

            Stats enemyStats = collision.GetComponent<Stats>();

            float critRoll = Random.Range(1, 100);
            float calcCritDmg = 1;

            if (critRoll <= playerStats.critRate)
            {
                calcCritDmg = playerStats.critDamage;
            }

            enemyStats.currentHealth -= (playerStats.finalAttack * attackScaling * calcCritDmg);

            Debug.Log("we has a trig");
        }
    }
}
