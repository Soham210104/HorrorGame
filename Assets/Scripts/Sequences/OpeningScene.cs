using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpeningScene : MonoBehaviour
{
    public GameObject FadeIn;
    public TextMeshProUGUI TextBox;
    public GameObject PlayerController;

    void Start()
    {

        PlayerController.GetComponent<FirstPersonMovement>().enabled = false;
        StartCoroutine(StartScene());
    }
    // Update is called once per frame
    IEnumerator StartScene() 
    {
        yield return new WaitForSeconds(1.5f);      
        FadeIn.SetActive(false);    
        TextBox.text = "I need to get out of here";   
        yield return new WaitForSeconds(2f);     
        TextBox.text = "";
        PlayerController.GetComponent<FirstPersonMovement>().enabled = true;
    
    }
}
