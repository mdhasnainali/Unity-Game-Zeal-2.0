using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    float runspeed = 40.0f;
    bool jump = false;
    public Animator animator;

    public PlayerPower SpeedOn;

    public PlayerPower ShieldOn;

    public PlayerPower JumpOn;

    public Transform CameraPos;

    float y;

    public Health Health;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.right.x);
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) { jump = true; }

        if (transform.position.y <= -5.8f || Health.health == 0)
        {
            animator.SetBool("Dead", true);

            CameraPos.position = new Vector2(CameraPos.position.x, y);

            SceneManager.LoadScene(4);
        }
        else { y = transform.position.y; }

     }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        //if (jump) { Debug.Log("Jump"); }

        jump = false;
        //Debug.Log(horizontalMove * Time.fixedDeltaTime);
    }
    public void SpeedPower()
    {
        runspeed = 30.0f;
    }

    public void SpeedIncrease()
    {
        runspeed = 60.0f;
    }

    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {


        if (collisioninfo.collider.tag == "SpeedEgg")
        {
            //Debug.Log("Speed");
            SpeedOn.SpeedPower();

        }
        if (collisioninfo.collider.tag == "ShieldEgg")
        {
            Debug.Log(collisioninfo.collider.tag);
            ShieldOn.ShieldPower();

        }
        if (collisioninfo.collider.tag == "JumpEgg")
        {
            Debug.Log(collisioninfo.collider.tag);
            JumpOn.JumpPower();

        }
    }
    
        


}
