using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 5.0f); 
    }

    
    void Destroy()
    {
        Destroy(this.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {

        Destroy(this.gameObject);


    }
}
