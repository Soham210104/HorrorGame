using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BFirstTrigger : MonoBehaviour
{
    public GameObject PlayerScript;
    public TextMeshProUGUI TextBox;
    public GameObject Marker;
    public GameObject Trigger;
    
    void OnTriggerEnter()
    {
        PlayerScript.GetComponent<FirstPersonMovement>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer() 
    {
        TextBox.text = "Oh!There is a weapon there.";
        yield return new WaitForSeconds(2.5f);
        TextBox.text = "";
        PlayerScript.GetComponent<FirstPersonMovement>().enabled = true;
        Trigger.GetComponent<BoxCollider>().enabled = false;
        Marker.SetActive(true);

    }

}
