using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchScript : MonoBehaviour
{
    Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        rot = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        rot = Quaternion.Euler(rot.eulerAngles.x, rot.eulerAngles.y, 0);
    }
}
