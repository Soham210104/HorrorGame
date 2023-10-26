using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DoorOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public float Distance;
    public GameObject actionText;
    public GameObject doorAnim;
    public AudioSource doorSound;
    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCast.DistanceFromPlayer; //we have the reference to the variable because of the static keyword.
    }

    //This works when mouse is hover over the GameObject to which script is attached
    void OnMouseOver()
    {
        if(Distance<=3)
        {
            actionText.SetActive(true);
        }
        else
        {
            actionText.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("E pressed");
            if(Distance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false; //this refers to the object where script is attached.
                actionText.SetActive(false);
                doorAnim.GetComponent<Animation>().Play("FirstDoorAnim");
                doorSound.Play();
            }
        }
    }
    
    void OnMouseExit()
    {
         actionText.SetActive(false);
    }
}
