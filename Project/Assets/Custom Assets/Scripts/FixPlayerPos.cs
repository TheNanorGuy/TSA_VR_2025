using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPlayerPos : MonoBehaviour
{
    public float z;
    public GameObject player;
    Vector3 pos;
    //bool cond = true;
    // Start is called before the first frame update
    void Start()
    {
        pos = player.transform.position;
        //yield return new WaitForSeconds(2f);
        //player.transform.position.Set(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        //if (cond) { player.transform.position = new Vector3(x, y, z); cond = false; }
        player.transform.position = new Vector3(pos.x, pos.y, z);
    }
}
