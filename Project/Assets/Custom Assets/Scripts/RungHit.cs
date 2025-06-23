using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RungHit : PointGet
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided With Something");
        if (other.gameObject.tag == "Projectile")
        {
            Debug.Log("Rung hit");
            displayPoints();
        }
    }
}
