using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarPosition : MonoBehaviour
{
    public Transform CameraPosition;
    public Transform BarPosition;

    void Update()
    {
        BarPosition.position = new Vector2(CameraPosition.position.x-17.0f, CameraPosition.position.y+10.0f);
    }
}
