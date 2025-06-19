using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginRingGame : MonoBehaviour
{
    public GameObject handR, handL;
    public float range;
    ProjectileSpawner game;
    bool active = true;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        game = FindObjectOfType<ProjectileSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("IT DONT EXIST" + (game == null));
        if (active && checkForHand()) { Debug.Log("Game On!"); game.gameCycle(); Debug.Log("Heckya!"); Destroy(this); }
    }

    bool checkForHand()
    {
        if (Vector3.Distance(pos, handL.transform.position) <= range) return true;
        if (Vector3.Distance(pos, handR.transform.position) <= range) return true;
        return false;
    }
}
