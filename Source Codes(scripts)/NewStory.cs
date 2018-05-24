using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewStory : MonoBehaviour {
    public GameObject Newstory;
    public GameObject GUI;
    
    
    

    public void CreateStory()
    {

        Vector2 V2 = new Vector2(200, 400);
        GameObject StoryClone = Instantiate(Newstory, transform) as GameObject;
        StoryClone.transform.position = V2;
        GUI = GameObject.Find("GUI");
        StoryClone.transform.parent = GUI.transform;
       

    }

}
