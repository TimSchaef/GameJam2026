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
        if (portal1 == false)
        {
            destination = GameObject.FindGameObjectWithTag("portal1").GetComponent<Transform>();
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("portal2").GetComponent<Transform>();
        }
            
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ball")
        {
            if (Vector2.Distance(transform.position, other.transform.position)> distance)
            {
                other.transform.position = new Vector2(destination.position.x, destination.position.y);
            }
        }
       
    }
}
