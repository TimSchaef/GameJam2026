using System;
using Unity.VisualScripting;
using UnityEngine;

public class teleport_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Transform destination;

    public bool portal1;
    public float distance = 0.2f;
    
    
    void Start()
    {
        destination = GetDestination();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ball")
        {
            if (Vector2.Distance(transform.position, other.transform.position)> distance)
            {
                destination = GetDestination();
                if(destination == null)
                    return;
                
                print(destination);
                other.transform.position = new Vector2(destination.position.x, destination.position.y);
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

                Quaternion delta = Quaternion.FromToRotation(transform.right, destination.right);
                rb.linearVelocity = delta*rb.linearVelocity;

                
            }
        }

    }

    Transform GetDestination()
    {
        if (!portal1)
        {
            GameObject portalOne = GameObject.FindGameObjectWithTag("portal1");
            return portalOne == null ? null : portalOne.transform;
        }
        else
        {
            GameObject protalTwo = GameObject.FindGameObjectWithTag("portal2");
            return protalTwo == null ? null : protalTwo.transform;
        }
    }
}

