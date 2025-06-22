using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterHandler : MonoBehaviour
{
    /*[TextArea(2, 10)]
    [SerializeField]*/
    public GameObject[] row1GamObj;
    public GameObject[] row2GamObj;
    public GameObject[] row3GamObj;
    public float gameTime, cycleTime, tweenTime;
    GameStart handler;
    bool gameActive;
    ShootingTarget[] row1, row2, row3;
    ShootingTarget[][] targets;
    ShootingTarget[] activeTargets;
    // Start is called before the first frame update
    void Start()
    {
        handler = FindObjectOfType<GameStart>();
        gameActive = false;
        SetUpTargets();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startGame()
    {
        StartCoroutine(gameCycle());
    }

    IEnumerator gameCycle()
    {
        gameActive = true;
        StartCoroutine(targetCycle());
        yield return new WaitForSeconds(gameTime);
        Debug.Log("Gungame over!");
        gameActive = false;
        handler.endScene();
    }

    IEnumerator targetCycle()
    {
        while (gameActive)
        {
            EstablishActiveTargets();
            yield return new WaitForSeconds(cycleTime);
            lowerTargets();
            yield return new WaitForSeconds(tweenTime);
        }
    }

    void EstablishActiveTargets()
    {
        activeTargets = new ShootingTarget[2];
        for (int i = 0; i < 2; i++)
        {
            int randRow = Random.Range(0, targets.Length-1);
            int randCol = Random.Range(0, targets[0].Length-1);
            Debug.Log("Row: " + randRow + ", Col: " + randCol);
            activeTargets[i] = targets[randRow][randCol];
            Debug.Log(activeTargets[i].gameObject.name);
        }

        foreach (ShootingTarget t in activeTargets) { t.goUp(); }
    }

    void lowerTargets()
    {
        foreach (ShootingTarget t in activeTargets)
        {
            if (t.isUp()) t.goDown();
        }
    }

    void SetUpTargets()
    {
        row1 = toTargetList(row1GamObj);
        row2 = toTargetList(row2GamObj);
        targets = new ShootingTarget[][] { row1, row2 };
        /*targets[0] = row1;
        targets[1] = row2;*/
        //printTargets(targets[0]);
        //Debug.Log(targets);
    }

    public bool gameOn()
    {
        return gameActive;
    }

    ShootingTarget[] toTargetList(GameObject[] list)
    {
        ShootingTarget[] newList = new ShootingTarget[list.Length];
        for (int i = 0; i < newList.Length; i++)
        {
            newList[i] = list[i].GetComponent<ShootingTarget>();
        }
        return newList;
    }

    void printTargets(ShootingTarget[] list)
    {
        foreach (ShootingTarget o in list) { Debug.Log(o.gameObject.name); }
    }

    void printTargets(ShootingTarget[][] list)
    {
        foreach (ShootingTarget[] r in list)
        {
            foreach (ShootingTarget c in r) { Debug.Log(c.gameObject.name); }
        }
    }
}
