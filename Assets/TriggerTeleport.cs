using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerTeleport : MonoBehaviour
{
    public GameObject objectToSpawn;

    public float cooldown = 1f;
    float timer = 0f;
    
    private void Update()
    {
        timer = timer + Time.deltaTime;

        if(timer >= cooldown)
        {
            GameObject.Instantiate(objectToSpawn, transform);
            timer -= cooldown;
        }
        
        
    }
}
