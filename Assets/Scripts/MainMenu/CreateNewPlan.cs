using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CreateNewPlan : MonoBehaviour
{
    public static float length = 100f;
    public static float width = 100f;
    public TMP_InputField iFLength;
    public TMP_InputField iFWidth;

    public void onCreateNewPlan()
    {
        length = float.Parse(iFLength.text);
        width = float.Parse(iFWidth.text);
        SceneManager.LoadScene("CreateNewPlan");
    }
}
