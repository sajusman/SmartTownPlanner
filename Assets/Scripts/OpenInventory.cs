using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OpenInventory : MonoBehaviour
{
    public GameObject openButton;
    public Button button;
    public Sprite Image1;
    public Sprite Image2;

    bool isOpen;
    bool isActive = false;
    public void openMenu()
    {
        //if (isActive == false)
        //{
        //   isActive = true;
        //openButton.SetActive(isActive);

      // public bool isOpen;
            Animator animator = openButton.GetComponent<Animator>();
                if (animator != null)
                {
                    
                     isOpen = animator.GetBool("open");
                     animator.SetBool("open", !isOpen);
                    // button.GetComponent<Image>().sprite = Image2;
        }

                if (!isOpen)
                {

                    button.GetComponent<Image>().sprite = Image2;

                }
                else if(isOpen)
                    button.GetComponent<Image>().sprite = Image1;


        // }
        /* else if (isActive == true)
         {
             print("closed");
             isActive = false;
            // openButton.SetActive(isActive);
             button.GetComponent<Image>().sprite = Image1;

         }*/

    }
    
}   
