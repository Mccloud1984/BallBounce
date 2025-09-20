using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectUpgrade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int movePosition = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("upgrade"))
        {
            Instantiate(this, new Vector3(transform.position.x, transform.position.y + movePosition, transform.position.z), this.transform.rotation);
            ScoreKeeper.GetScoreKeeper().AddScore();
            Destroy(other.gameObject);
        }
    }
}
