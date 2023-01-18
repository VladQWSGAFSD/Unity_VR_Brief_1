using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChange : MonoBehaviour, IUsableObject
{
    public void UseObject() { ChangeColor(); }


    private void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.SetColor("_BaseColor", Color.green);
        //GetComponentInChildren<MeshRenderer>().material.SetColor("_BaseColor", Color.green);
    }
}