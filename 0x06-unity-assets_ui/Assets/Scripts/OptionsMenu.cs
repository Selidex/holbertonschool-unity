using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public void Back(){
        string p = PlayerPrefs.GetString("Prev");
        SceneManager.LoadScene(p);
    }
}
