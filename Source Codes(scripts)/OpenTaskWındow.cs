using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OpenTaskWındow : MonoBehaviour, IPointerDownHandler
{

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    public void OnPointerDown(PointerEventData data)
    {
        clicked++;
        if (clicked == 1) clicktime = Time.time;

        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            SceneManager.LoadScene("Story Detail");
            

        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;

    }
}