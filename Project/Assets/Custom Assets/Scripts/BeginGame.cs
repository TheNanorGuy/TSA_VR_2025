using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{
    public GameObject handR, handL;
    public float range;
    ProjectileSpawner projGame;
    ShooterHandler gunGame;
    bool active = true;
    public bool needsProjectiles;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        projGame = FindObjectOfType<ProjectileSpawner>();
        gunGame = FindObjectOfType<ShooterHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("IT DONT EXIST" + (projGame == null));
        if (active && checkForHand())
        {
            Debug.Log("Game On!");
            if (needsProjectiles) { projGame.gameCycle(); Debug.Log("Heckya!"); Destroy(this); }
            else { gunGame.startGame(); Destroy(this); }
        }
    }

    bool checkForHand()
    {
        if (Vector3.Distance(pos, handL.transform.position) <= range) return true;
        if (Vector3.Distance(pos, handR.transform.position) <= range) return true;
        return false;
    }
}
