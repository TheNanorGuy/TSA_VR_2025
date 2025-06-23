using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public string nextScene;
    public GameObject handL, handR;
    bool active;
    // Start is called before the first frame update
    void Start()
    {
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (active && getHand()) switchScene();
    }

    bool getHand()
    {
        if (handL.transform.position == gameObject.transform.position) return true;
        if (handR.transform.position == gameObject.transform.position) return true;
        return false;
    }

    public void switchScene()
    {
        if (active) { active = false; SceneManager.LoadScene(nextScene); }
    }
}
