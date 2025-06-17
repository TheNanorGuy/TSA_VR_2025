using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginRingGame : MonoBehaviour
{
    public GameObject handR, handL;
    public float range;
    SpawnRings game;
    bool active = true;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        game = FindObjectOfType<SpawnRings>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ring button is alive");
        if (active && checkForHand()) { Debug.Log("Game On!"); game.gameCycle(); Destroy(this); }
    }

    bool checkForHand()
    {
        if (Vector3.Distance(pos, handL.transform.position) <= range) return true;
        if (Vector3.Distance(pos, handR.transform.position) <= range) return true;
        return false;
    }
}
