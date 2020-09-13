using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraSwitch : MonoBehaviour
{

    public Sprite move;
    public Sprite transforms;
    public Button button;

    public GameObject MovementCamera;
    public GameObject TransformCamera;
    bool isTransform = false;


    public GameObject buttons;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform newTrans = MovementCamera.transform;
        //Position, rotation, scale
        Vector3 newPos = newTrans.position;
        Quaternion newRot = newTrans.rotation;
        TransformCamera.transform.position = newPos;
        TransformCamera.transform.rotation = newRot;

    }


    public void switchCamera()
    {

        if (!isTransform)
        {
            buttons.SetActive(true);
            TransformCamera.SetActive(true);
            MovementCamera.SetActive(false);
            isTransform = true;
            button.GetComponent<Image>().sprite = transforms;



        }
        else
        {
            buttons.SetActive(false);
            TransformCamera.SetActive(false);
            MovementCamera.SetActive(true);
            isTransform = false;
            button.GetComponent<Image>().sprite = move;


        }

    }


}
