using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour, IUsableObject
{
    [SerializeField] private Light _light;
    [SerializeField] private MeshRenderer _lightEmissive;


    private void ToggleLight()
    {
        _light.enabled = !_light.enabled;
        if (_light.enabled)
        {
            _lightEmissive.material.EnableKeyword("_EMISSION");
        }
        else
        {
            _lightEmissive.material.DisableKeyword("_EMISSION");
        }
    }

    public void UseObject()
    {

        ToggleLight();

    }
}