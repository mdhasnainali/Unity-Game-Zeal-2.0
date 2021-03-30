using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public int Button2Pos = 0;
    public void Button2Clicked()
    {
        transform.Rotate(0f, 0f, 90f);
        Button2Pos++;
        if (Button2Pos == 4) { Button2Pos = 0; }
    }
}
