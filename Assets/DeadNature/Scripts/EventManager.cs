using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private MeshRenderer _lightEmissive;
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }

    private void TalkToLight(Light light)
    {
        light.enabled = !light.enabled;
    }



}
