using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAudio : MonoBehaviour
{
    public AudioSource music;
    public AudioSource waves;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
