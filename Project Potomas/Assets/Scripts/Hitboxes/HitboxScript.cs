using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    public float attackScaling = 1f;
    public GameObject hitboxSpawner;

    // Update is called once per frame

    private void Awake()
    {
    }

    // waiting for the hitboxSpawner variable to update to whatever spawned the hitbox


    // just made a method for damage calc because its much easier
    static void Damage(GameObject attacker, GameObject defender, float attackScaling)
    {
        Stats attackerStats = attacker.GetComponent<Stats>();

        Stats defenderStats = defender.GetComponent<Stats>();

        float critRoll = Random.Range(1, 100);
        float calcCritDmg = 1;

        if (critRoll <= attackerStats.critRate)
        {
            calcCritDmg = attackerStats.critDamage;
        }

        defenderStats.currentHealth -= (attackerStats.finalAttack * attackScaling * calcCritDmg);

        Debug.Log("we has a trig");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "PlayerHitbox" && collision.gameObject.tag == "Enemy")
        {
            Damage(hitboxSpawner, collision.gameObject, attackScaling);
        }
        else if (gameObject.tag == "EnemyHitbox" && collision.gameObject.tag == "Player")
        {
            Damage(hitboxSpawner, collision.gameObject, attackScaling);
        }
    }
}