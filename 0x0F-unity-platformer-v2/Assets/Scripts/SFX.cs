using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
   public AudioSource btnsound;
   public AudioClip hoversfx;
   public AudioClip clicksfx;

   public void HoverSound()
   {
       btnsound.PlayOneShot(hoversfx);
   }

   public void ClickSound()
   {
       btnsound.PlayOneShot(clicksfx);
   }
}
