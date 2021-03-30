using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClosedCave : MonoBehaviour
{
    public GameObject OpenCavePrefab;
   
    
    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        //Debug.Log(collisioninfo.collider.name);

        if (collisioninfo.collider.name == "player")
        {
            Invoke("OpenCaveOn", 2.0f);
            

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1,LoadSceneMode.Additive);
        }

    }

    public void OpenCaveOn()
    {
        Destroy(this.gameObject);

        Instantiate(OpenCavePrefab, transform.position, transform.rotation);
    }
}
