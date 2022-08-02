using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    private PlayerMovement2d script;

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            rb = player.GetComponent<Rigidbody>();
            script = player.GetComponent<PlayerMovement2d>();
            PushPlayer();
        }
    }


    void PushPlayer()
    {
        script.enabled = false;
        rb.AddForce(Vector3.up * 500);

        if(player.transform.position.x < transform.position.x)
        {
            rb.AddForce(Vector3.right * -500);
        }
        else
        {
            rb.AddForce(Vector3.right * 500);
        }
    }
}
