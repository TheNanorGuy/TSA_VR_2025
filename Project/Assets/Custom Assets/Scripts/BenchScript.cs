using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchScript : MonoBehaviour
{
    Quaternion rot;
    Quaternion lRot;
    public GameObject wheel;
    // Start is called before the first frame update
    void Start()
    {
        rot = gameObject.transform.rotation;
        lRot = gameObject.transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Bench angle is " + rot.eulerAngles.z);
        rot = Quaternion.Euler(rot.eulerAngles.x, rot.eulerAngles.y, rot.eulerAngles.z + wheel.transform.rotation.eulerAngles.z);
        gameObject.transform.rotation = rot;
    }
}
