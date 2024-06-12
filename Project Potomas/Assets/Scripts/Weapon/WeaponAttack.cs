using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    public GameObject basicOne;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject spawnedBasicOne = GameObject.Instantiate(basicOne, transform.position, transform.rotation);
            HitboxScript spawnedHitboxScript = spawnedBasicOne.GetComponent<HitboxScript>();
            spawnedHitboxScript.hitboxSpawner = player;
        }
    }
}