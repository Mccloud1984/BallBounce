using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static bool BallFell = false;
    public Object PlayerObject;
    private object lockObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (BallFell == true)
        {
            BallFell = false;
            int playerCount = GameObject.FindGameObjectsWithTag("Player").Length;
            if(playerCount <= 0)
            {
                Instantiate(PlayerObject);
            }
        }
    }

}
