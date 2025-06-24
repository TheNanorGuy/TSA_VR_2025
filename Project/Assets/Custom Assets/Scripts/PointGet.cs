using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointGet : MonoBehaviour
{
    public float xAdj, yAdj, zAdj;
    public float rotFix;
    public int pointAmount;
    public AudioSource pointSFX;
    public GameObject pointPrefab;
    Quaternion rot;
    Quaternion newRot;
    // Start is called before the first frame update
    void Start()
    {
        rot = gameObject.transform.rotation;
        newRot = Quaternion.Euler(rot.eulerAngles.x, rot.eulerAngles.y + rotFix, rot.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayPoints() {
        pointSFX.Play();
        /*GameObject ui = Instantiate(pointPrefab, gameObject.transform.position + new Vector3(xAdj, yAdj, zAdj), newRot);
        ui.GetComponentInChildren<Text>().text = "" + pointAmount;*/
    }
}
