using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    [SerializeField] private Animator lid = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("player moved in");
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                lid.Play("TrashAnim", 0, 0.0f);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("player moved out");
        if (other.CompareTag("Player"))
        {
            if (closeTrigger)
            {
                lid.Play("TrashAnimClose", 0, 0.0f);
            }
        }

    }
}
