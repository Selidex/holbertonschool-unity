using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float starttime;


    // Start is called before the first frame update
    void Start()
    {
        starttime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time - starttime;
        string minutes = ((int) time / 60).ToString();
        string seconds = (time % 60).ToString("f2");
        TimerText.text = minutes + ":" + seconds;
    }
}
