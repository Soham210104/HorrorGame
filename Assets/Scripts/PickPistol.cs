using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PickPistol : MonoBehaviour
{
    // Start is called before the first frame update
    public float Distance;
    public TextMeshProUGUI actionText;
    public GameObject fakePistol;
    public GameObject realPistol;
    public AudioSource gunPickup;
    public GameObject Arrow;
    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCast.DistanceFromPlayer; 
    }


    void OnMouseOver()
    {
        if (Distance <= 3)
        {
            actionText.text = "Press E to pickup Pistol.";
        }
        else
        {
            actionText.text = "";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Distance <= 3)
            {
                fakePistol.SetActive(false);
                realPistol.SetActive(true);
                Arrow.SetActive(false);
                gunPickup.Play();
                actionText.text = "";
            }
        }
    }

    void OnMouseExit()
    {
        actionText.text = "";
    }
}
