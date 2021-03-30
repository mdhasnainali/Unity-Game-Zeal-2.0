using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCheck : MonoBehaviour
{
    public Button0 Button0;
    public Button1 Button1;
    public Button2 Button2;

 

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Not Done");
        if(Button0.Button0Pos ==3 & Button1.Button1Pos ==1 & Button2.Button2Pos ==0)
        {
            SceneManager.UnloadScene(2);
        }
    }
}
