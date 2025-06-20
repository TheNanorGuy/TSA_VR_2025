using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ShootingTarget : PointGet
{
    public Animator animator;
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("TargetActive? " + active);
    }

    public void goUp()
    {
        animator.Play("GoUp");
    }

    public void setActive()
    {
        active = true;
    }

    public void goDown()
    {
        active = false; animator.Play("GoDown");
    }

    public bool isUp()
    {
        return active;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile") { goDown(); displayPoints(); }
    }
}
