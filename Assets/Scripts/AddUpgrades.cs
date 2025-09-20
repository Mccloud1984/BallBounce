using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddUpgrades : MonoBehaviour
{

    //Spawn this object
    public GameObject spawnObject;

    public float maxTime = 5;
    public float minTime = 2;

    public int maxUpgrades = 10;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            int upgrades = GameObject.FindGameObjectsWithTag("upgrade").Length;
            if(upgrades <= maxUpgrades)
            {
                SpawnObject();
                SetRandomTime();
            }
        }

    }
    public Vector3 RandomPointInBounds()
    {
        Collider collider = GetComponent<Collider>();
        Bounds bounds = collider.bounds;
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }

    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = minTime;
        Vector3 position = RandomPointInBounds();
        Instantiate(spawnObject, position, spawnObject.transform.rotation);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
