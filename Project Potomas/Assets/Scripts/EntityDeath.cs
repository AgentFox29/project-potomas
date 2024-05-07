using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityDeath : MonoBehaviour
{
    Stats stats;

    // Start is called before the first frame update
    void Awake()
    {
        stats = GetComponent<Stats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stats.currentHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
