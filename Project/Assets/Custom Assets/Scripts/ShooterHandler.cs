using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterHandler : MonoBehaviour
{
    public GameObject[] row1GamObj;
    public GameObject[] row2GamObj;
    public GameObject[] row3GamObj;
    public float gameTime, cycleTime, tweenTime;
    bool gameActive;
    ShootingTarget[] row1, row2, row3;
    ShootingTarget[][] targets;
    ShootingTarget[] activeTargets;
    // Start is called before the first frame update
    void Start()
    {
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
        gameActive = false;
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
        for (int i = 0; i< 3; i++)
        {
            int randRow = Random.Range(0, targets.Length);
            int randCol = Random.Range(0, targets[0].Length);
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

        Debug.Log(targets);
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
}
