using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float timeSpawn = 2.0f;
    public float horzOffset = 11.5f;

    private bool isCoolDown = false;

    // Update is called once per frame
    void Update()
    {
        if (isCoolDown == false)
        {
            SpawnEnemy();
            StartCoroutine(SpawningCoolDown());
        }
    }

    IEnumerator SpawningCoolDown()
    {
        isCoolDown = true;
        yield return new WaitForSeconds(timeSpawn);
        isCoolDown = false;
    }
    void SpawnEnemy()
    {
        float lowestX = transform.position.x - horzOffset;
        float highestX = transform.position.x + horzOffset;

            Instantiate(enemyPrefab, new Vector3(Random.Range(lowestX, highestX), transform.position.y, transform.position.z), transform.rotation);
    }
}
