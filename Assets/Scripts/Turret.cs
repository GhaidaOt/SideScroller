using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Transform player;
    private bool detected = false;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bullet;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.LookAt(player);
        DetectingPlayer();
    }

    void DetectingPlayer()
    {
        float playerDistance = Vector3.Distance(player.transform.position, transform.position);

        if(playerDistance <=15 && detected == false)
        {
            detected = true;
            InvokeRepeating("Shooting", 0, 1);
        }
        else if (playerDistance > 15)
        {
            detected = false;
            CancelInvoke("Shooting");
        }
    }

    void Shooting()
    {
        Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.transform.rotation);
    }
}
