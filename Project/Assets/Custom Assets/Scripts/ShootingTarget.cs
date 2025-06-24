using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ShootingTarget : PointGet
{
    public Animator animator;
    //public AudioSource hitSFX;
    //public Light light;
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
        //light.intensity = 2;
    }

    public void setActive()
    {
        active = true;
    }

    public void goDown()
    {
        //hitSFX.Play();
        active = false; animator.Play("GoDown");
        //light.intensity = 0;
    }

    public bool isUp()
    {
        return active;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active && other.gameObject.tag == "Projectile") { goDown(); displayPoints(); }
    }
}
