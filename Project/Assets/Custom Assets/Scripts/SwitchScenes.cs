using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public string nextScene;
    public GameObject handL, handR;
    Vector3 pos;
    float range;
    bool active;
    // Start is called before the first frame update
    void Start()
    {
        active = true;
        range = 0.0005f;
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (active && getHand()) switchScene();
    }

    bool getHand()
    {
        if (Vector3.Distance(pos, handL.transform.position) <= range) return true;
        if (Vector3.Distance(pos, handR.transform.position) <= range) return true;
        return false;
    }

    public void switchScene()
    {
        if (active) { active = false; SceneManager.LoadScene(nextScene); }
    }
}
