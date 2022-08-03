using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] Transform spawnPoint;
    void Update()
    {
        if (health <= 0)
            Die();
    }

    void Die()
    {
        transform.position = spawnPoint.position;
        health = 3;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
        }
    }
}
