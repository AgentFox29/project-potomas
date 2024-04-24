using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float moveSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (rigidbody.position.y >= 12)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + new Vector2(0, 1) * moveSpeed * Time.fixedDeltaTime);
    }
}
