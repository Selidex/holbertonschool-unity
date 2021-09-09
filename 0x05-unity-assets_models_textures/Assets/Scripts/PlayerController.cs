using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerController : MonoBehaviour
{
    Vector3 respawn = new Vector3(0,20,0);
    

    

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y < -20)
            this.gameObject.transform.position = respawn;
    }
}
