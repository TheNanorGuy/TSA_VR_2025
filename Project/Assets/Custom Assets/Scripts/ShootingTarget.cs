using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTarget : MonoBehaviour
{
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goUp()
    {
        
    }

    public void setActive()
    {
        active = true;
    }

    public void goDown()
    {
        active = false;
    }

    public bool isUp()
    {
        return active;
    }
}
