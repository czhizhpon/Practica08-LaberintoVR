using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWaypoint : MonoBehaviour {

    public GameObject objetoACrear;
    public float xPosition;
    public float yPosition;
    public float zPosition;

    bool wasCreate = false;
    
    public void ObjectMaker()
    {
        if (!wasCreate)
            Object.Instantiate(objetoACrear, new Vector3(xPosition,  yPosition, zPosition), Quaternion.identity);
        wasCreate = true;
    }
}
