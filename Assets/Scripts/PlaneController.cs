using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public Vector3 velocity = Vector3.up;
    public float smooth = 2.0F;
    public float tiltAngle = 3.0F;
    private float lastHorz = 0F;
    private float lastVert = 0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentHorz = Input.GetAxis("Horizontal");
        float currentVert = Input.GetAxis("Vertical");
        //if(currentHorz == 0 && currentVert == 0)
        //{
        //    if(lastHorz == 0 && lastVert == 0)
        //    {
        //        return;
        //    } 
        //    currentHorz = lastHorz;
        //    currentVert = lastVert;
        //}
        float tiltAroundZ = currentHorz * tiltAngle;
        float tiltAroundX = currentVert * tiltAngle;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
        //Debug.Log("Tilting to z: " + tiltAroundZ.ToString() + ", x: " + tiltAroundX.ToString());
        lastHorz = currentHorz;
        lastVert = currentVert;
    }
}
