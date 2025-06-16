using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteText : MonoBehaviour
{
    GameObject parentObj;
    // Start is called before the first frame update
    void Start()
    {
        parentObj = gameObject.GetComponent<RectTransform>().parent.parent.gameObject; //Parent only moves 1 up the hierarchy.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void delete() { Destroy(parentObj); }
}
