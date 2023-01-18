using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChangeModel : MonoBehaviour,IUsableObject
{
    public void UseObject() { ChangeModel(); }
    [SerializeField] GameObject originalObject;
    [SerializeField] GameObject newModel;
    bool change = false;

    private void ChangeModel()
    {
        
        if(!change)
        {
            Destroy(originalObject);
            Instantiate(newModel, transform.position, transform.rotation);
        }
        else
        {
            Destroy(newModel);
            Instantiate(originalObject, transform.position, transform.rotation);
        }
    
    }
}
