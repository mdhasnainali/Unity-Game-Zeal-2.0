using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button0 : MonoBehaviour
{
    public int Button0Pos =0;
    public void Button0Clicked()
    {
        transform.Rotate(0f, 0f, 90f);
        Button0Pos++;
        if (Button0Pos == 4) { Button0Pos = 0; }
    }
}
