using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    [SerializeField] float shrink;
    [SerializeField] float grow;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localScale = new Vector3(shrink, shrink, shrink);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.localScale = new Vector3(grow, grow, grow);
        }
    }
}
