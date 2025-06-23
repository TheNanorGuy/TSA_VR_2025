using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeleter : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 5;
        StartCoroutine(Del());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Del()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
