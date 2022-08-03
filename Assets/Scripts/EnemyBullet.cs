using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed;
    [SerializeField] float lifeSpan;
    private Rigidbody rb;
    private PlayerHealth playerHealth;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed);
        Invoke("Delete", lifeSpan);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealth.health--;
            Destroy(gameObject);

        }
    }

    void Delete()
    {
        Destroy(gameObject);
    }
}
