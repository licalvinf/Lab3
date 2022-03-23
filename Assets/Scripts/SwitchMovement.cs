using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMovement : MonoBehaviour
{
    [SerializeField] private Animator lightswitch = null;
    [SerializeField] private bool onTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (onTrigger)
            {
                lightswitch.Play("SwitchOn", 0, 0.0f);
            }
        }
    }
}
