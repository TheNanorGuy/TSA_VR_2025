using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRecovery : MonoBehaviour
{
    public float x, y, z, barrier;
    Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        point = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < barrier)
        {
            gameObject.transform.position = point;
        }
    }
}
