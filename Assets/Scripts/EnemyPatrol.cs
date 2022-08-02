using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float playerDistance = Vector3.Distance(player.transform.position, transform.position);
        Debug.Log("this much: " + playerDistance);
        
    }
}
