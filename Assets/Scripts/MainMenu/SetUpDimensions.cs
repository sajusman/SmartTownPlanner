using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpDimensions : MonoBehaviour
{
    public GameObject Land;
    private void Awake()
    {
        transform.localScale = new Vector3(CreateNewPlan.length, 1.0f, CreateNewPlan.width);
    }
}
