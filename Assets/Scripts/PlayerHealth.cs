using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    [SerializeField] Transform spawnPoint;
    private Rigidbody rb;
    private PlayerMovement2d script;

    private Transform enemy;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        script = GetComponent<PlayerMovement2d>();
    }

    void Update()
    {
        if (health <= 0)
            Die();
    }

   

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            enemy = collision.gameObject.transform;
            Damage();
        }
    }

    void Damage()
    {
        script.enabled = false;
        rb.AddForce(Vector3.up * 250);

        if (transform.position.x < enemy.position.x)

            rb.AddForce(Vector3.right * -500);

        else

            rb.AddForce(Vector3.right * 500);

        Invoke("MoveAgain", 1);
    }


    void MoveAgain()
    {
        script.enabled = true;

    }

    void Die()
    {
        transform.position = spawnPoint.position;
        health = 3;
    }
}
