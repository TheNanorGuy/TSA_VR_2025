using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GunScript : MonoBehaviour
{
    public GameObject output;
    public GameObject ball;
    public ControllerData data;
    public AudioSource source;
    public float delay;
    bool delayed = false;
    bool held;
    // Start is called before the first frame update
    void Start()
    {
        held = false;
    }

    // Update is called once per frame
    void Update()
    { 
        Debug.Log("Is held?" + held);

        if (data.handL.TryGetFeatureValue(CommonUsages.triggerButton, out bool trig1))
        {
            if (held&&trig1&&!delayed)
            {
                shoot();
                StartCoroutine(DelayShoot());
            }
        }
        if (data.handR.TryGetFeatureValue(CommonUsages.triggerButton, out bool trig2))
        {
            if (held&&trig2&&!delayed)
            {
                shoot();
                StartCoroutine(DelayShoot());
            }
        }
    }

    void shoot()
    {
        source.Play();
        GameObject obj = Instantiate(ball, output.transform.position, output.transform.rotation);
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.velocity += obj.transform.forward * 1/*(10 * obj.transform.localScale.magnitude)*/;
    }

    public void setIsHeld()
    {
        held = !held;
        Debug.Log("Gun held?" + held);
    }

    IEnumerator DelayShoot()
    {
        delayed = true;
        yield return new WaitForSeconds(delay);
        delayed = false;
    }
}
