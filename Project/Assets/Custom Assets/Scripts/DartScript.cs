using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartScript : MonoBehaviour
{
    public Rigidbody rb;
    GameObject par;
    Quaternion rot;
    bool released;
    // Start is called before the first frame update
    void Start()
    {
        //par = gameObject.transform.parent.gameObject.transform.parent.gameObject;
        released = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (released) gameObject.transform.rotation = rot;
    }

    public void setRotation()
    {
        rot = gameObject.transform.rotation;
        rb.velocity += gameObject.transform.forward * 10;
        released = true;
    }

    public void grabbed()
    {
        released = false;
    }
}
