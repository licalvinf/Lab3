using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    Light light;
    [SerializeField] private bool onTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        light = GameObject.Find("Sun").GetComponent<Light>();
        light.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (onTrigger)
            {
                light.enabled = true;
            }
        }
        
    }
}
