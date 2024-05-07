using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    public float despawnTime;
    public float attackScaling = 1;
    public float critDamage = 1;

    Stats playerStats;
    Stats enemyStats;


    // Start is called before the first frame update
    void Awake()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<Stats>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        { 
            enemyStats = collision.gameObject.GetComponent<Stats>();

            float calcCrit = Random.Range(0, 101);

            if (calcCrit < playerStats.critRate)
            {
                critDamage = playerStats.critDamage;
            }
            else
            {
                critDamage = 1;
            }

            enemyStats.currentHealth -= (playerStats.finalAttack * attackScaling * critDamage);
            Debug.Log("Collision Happened");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (despawnTime <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            despawnTime -= 1 * Time.deltaTime;
        }
    }
}
