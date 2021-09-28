using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text TimerText;
    public Text WinTime;
    public GameObject WinCanvas;
    public float starttime;
    float time;


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        time = Time.time - starttime;
        string minutes = ((int) time / 60).ToString();
        string seconds = (time % 60).ToString("f2");
        TimerText.text = minutes + ":" + seconds;
    }
    public void Win(){
        float wt = time;
        string minutes = ((int) wt / 60).ToString();
        string seconds = (wt % 60).ToString("f2");
        WinTime.text = minutes + ":" + seconds;
        WinCanvas.gameObject.SetActive(true);
        
    }
}
