using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterHandler : MonoBehaviour
{
    public GameObject[] row1GamObj, row2GamObj, row3GamObj;
    public float gameTime, cycleTime, tweenTime;
    bool gameActive;
    ShootingTarget[,] targets;
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
            int randCol = Random.Range(0, targets.GetLength(0));
            activeTargets[i] = targets[randRow, randCol];
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
        GameObject[] toUse = row1GamObj;
        targets = new ShootingTarget[2,5];
        for (int r = 0; r < targets.GetLength(0); r++)
        {
            switch(r)
            {
                case 0: toUse = row1GamObj; break;
                case 1: toUse = row2GamObj; break;
                case 2: toUse = row3GamObj; break;
                default: toUse = row1GamObj; break;
            }

            for (int c = 0; c < targets.GetLength(1); c++)
            {
                targets[r, c] = toUse[c].GetComponent<ShootingTarget>();
            }
        }
    }

    public bool gameOn()
    {
        return gameActive;
    }
}
