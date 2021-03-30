using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCave : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        //Debug.Log(collisioninfo.collider.name);

        if (collisioninfo.collider.name == "player")
        {
            SceneManager.LoadScene(3);
        }

    }
}
