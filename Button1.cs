using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public int Button1Pos = 0;
    public void Button1Clicked()
    {
        transform.Rotate(0f, 0f, 90f);
        Button1Pos++;
        if (Button1Pos == 4) { Button1Pos = 0; }
    }
}
