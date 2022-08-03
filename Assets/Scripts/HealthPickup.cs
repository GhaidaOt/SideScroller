using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private PlayerHealth healthScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            healthScript = other.gameObject.GetComponent<PlayerHealth>();
            if(healthScript.health < 3)
            healthScript.health++;

            Destroy(this.gameObject);
        }
    }
}
