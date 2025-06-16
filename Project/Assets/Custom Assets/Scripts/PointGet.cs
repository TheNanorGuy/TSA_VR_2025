using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointGet : MonoBehaviour
{
    public float xAdj, yAdj, zAdj;
    public int pointAmount;
    public GameObject pointPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayPoints() {
        GameObject ui = Instantiate(pointPrefab, gameObject.transform.position + new Vector3(xAdj, yAdj, zAdj), gameObject.transform.rotation);
        ui.GetComponentInChildren<Text>().text = "" + pointAmount;
    }
}
