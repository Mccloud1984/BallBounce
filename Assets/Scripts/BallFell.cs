using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFell : MonoBehaviour
{
    bool fell = false;
    public float fallPosittion = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= fallPosittion && fell == false)
        {
            Destroy(gameObject, 0);
            GameControl.BallFell = true;
            fell = true;
        }
    }
}
