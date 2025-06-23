using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource outro;
    public bool needsProjectiles;
    string mapScene = "BasicScene";
    ProjectileSpawner projGame;
    ShooterHandler gunGame;
    // Start is called before the first frame update
    void Start()
    {
        projGame = FindObjectOfType<ProjectileSpawner>();
        gunGame = FindObjectOfType<ShooterHandler>();
        StartCoroutine(WaitAMoment());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endScene()
    {
        StartCoroutine(end());
    }

    void StartAGame()
    {
        if (needsProjectiles) projGame.gameCycle();
        else gunGame.startGame();
    }

    IEnumerator WaitAMoment()
    {
        yield return new WaitForSeconds(2f);
        intro.Play();
        yield return new WaitUntil(() => !intro.isPlaying);
        StartAGame();
    }

    IEnumerator end()
    {
        outro.Play();
        yield return new WaitUntil(() => !outro.isPlaying);
        SceneManager.LoadScene(mapScene);
    }
}
