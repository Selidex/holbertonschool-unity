using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    int test = 0;
    void OnTriggerExit(Collider other) {
        if (test == 0)
        {
            test = 1;
            other.GetComponent<Timer>().enabled = true;
        }
    }
}
