using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    private GameObject player;
    private bool detected = false;
    [SerializeField] private float speed;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float playerDistance = Vector3.Distance(player.transform.position, transform.position);
      //  Debug.Log("this much: " + playerDistance);

        if(playerDistance <= 10 && detected == false)
        {
            detected = true;
        }

        if (detected == true)
        {
            if (player.transform.position.x < transform.position.x)
                transform.Translate(Vector3.right * -speed * Time.deltaTime);
            else
             transform.Translate(Vector3.right * speed * Time.deltaTime); 
        }
    }
}
