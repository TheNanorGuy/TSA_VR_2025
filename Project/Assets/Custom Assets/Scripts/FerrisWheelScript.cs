using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FerrisWheelScript : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Begin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Begin()
    {
        yield return new WaitForSeconds(3f);
        animator.Play("Rotate");
    }

    public void switchScene()
    {
        SceneManager.LoadScene("WhereTo");
    }
}
