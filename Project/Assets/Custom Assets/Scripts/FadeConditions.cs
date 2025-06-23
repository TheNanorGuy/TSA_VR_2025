using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class FadeConditions : MonoBehaviour
{
    int nextScene;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.Play("FadeIn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScene(int s) { nextScene = s; animator.Play("FadeOut"); }

    public void switchScene() { SceneManager.LoadScene(nextScene); }
}
