using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RuntimeGizmos;

public class TransformGizmoButtons : MonoBehaviour
{
    public TransformGizmo TGScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeTransform(string type)
    {
        if (type == "Move")
            TGScript.transformType = TransformType.Move;
        else if (type == "Rotate")
            TGScript.transformType = TransformType.Rotate;
        else if (type == "Scale")
            TGScript.transformType = TransformType.Scale;

      /*  switch (Type)s
        {
            case "Move":
                {
                    TGScript.transformType = TransformType.Move;
                    break;
                }
            case "Rotate":
                {
                    TGScript.transformType = TransformType.Rotate;
                    break;
                }

        }*/
    }
}