using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float intensityAmount = 10f;
    [SerializeField] float restoreAngle = 70f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FlashLightSystem playerFlashlight = other.transform.GetComponentInChildren<FlashLightSystem>();
            onPickup(playerFlashlight);
            Destroy(gameObject);

        }
    }
        private void onPickup(FlashLightSystem playerFlashlight)
    {
        
        playerFlashlight.RestoreLightAngle(restoreAngle);
        playerFlashlight.RestoreLightIntensity(intensityAmount);
    }
}
