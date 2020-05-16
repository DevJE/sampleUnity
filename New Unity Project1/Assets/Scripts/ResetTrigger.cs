using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.transform.tag == "Player")
        {
            doJumpRigidBody2D playerComponent = collision.GetComponent<doJumpRigidBody2D>();
            if (null != playerComponent)
            {
                playerComponent.SetInitPosition();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collisionEnter");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collisionEnter2D");
    }


}
