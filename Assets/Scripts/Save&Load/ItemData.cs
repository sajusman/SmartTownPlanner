using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData
{
    public float[] position;
    public string name;
    
    public ItemData(Vector3 data , string name)
    {
        position = new float[3];
        position[0] = data.x;
        position[1] = data.y;
        position[2] = data.z;
        this.name = name;
    }
}
