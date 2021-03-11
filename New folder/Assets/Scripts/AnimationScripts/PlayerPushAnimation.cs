using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPushAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    private bool isPaused = false;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            myAnimationController.SetBool("isDoor", true);
  
        }
        isPaused = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (isPaused)
        {
            if (other.CompareTag("Door"))
            {
                myAnimationController.SetBool("isDoor", false);
            }
        }
    }
}
