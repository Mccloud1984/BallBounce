using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseBallSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public int force;
 
    void OnTriggerEnter(Collider hit)
    {
        //if (hit.GetComponent<Rigidbody>())
        //{
        //    transform.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(transform.position.x, transform.position.y + force, transform.position.z));
        //}
    }
}
