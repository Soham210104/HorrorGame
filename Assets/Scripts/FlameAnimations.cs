using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour
{
    
    public int LightMode;
    public GameObject Light;//reference created for light illumination.

    // Update is called once per frame
    void Update()
    {
        if (LightMode == 0)
        {
            StartCoroutine(LightAnimation());
        }
    }

    IEnumerator LightAnimation() 
    {
        LightMode = Random.Range(1, 4);
        switch(LightMode) 
        {
            case 1:
                Light.GetComponent<Animation>().Play("TorchAnim1");
                break;
            case 2:
                Light.GetComponent<Animation>().Play("TorchAnim2");
                break;
            case 3:
                Light.GetComponent<Animation>().Play("TorchAnim3");
                break;
        }
            yield return new WaitForSeconds(1f);
        LightMode = 0;
    }
}
