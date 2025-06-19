using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject ringPrefab;
    public float gameTime, spawnDelay;
    Vector3 pos;
    Quaternion rot;
    bool gameStarted;
    bool delay = false;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        rot = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted && !delay) { Debug.Log("Spawning"); StartCoroutine(RunDelay()); Instantiate(ringPrefab, pos, rot); }
    }

    public void gameCycle()
    {
        StartCoroutine(game());
    }

    IEnumerator game()
    {
        gameStarted = true;
        Debug.Log("Game Started");
        yield return new WaitForSeconds(gameTime);
        Debug.Log("Game Over");
        gameStarted = false;
    }

    IEnumerator RunDelay()
    {
        Debug.Log("Wait");
        delay = true;
        yield return new WaitForSeconds(spawnDelay);
        Debug.Log("Delay over");
        delay = false;
    }
}
