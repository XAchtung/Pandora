using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;

    Animator playerAnim;

    public float speed = 10f;
    public PickUp SwordOnPlayer;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;



    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f,angle, 0f);
            controller.Move(direction*speed*Time.deltaTime);
        }

        //amimation
        if(direction == Vector3.zero)
        {
            playerAnim.SetFloat("speed", 0);
        }
        else
        {
            if (SwordOnPlayer.sword == true)
            {
                playerAnim.SetBool("sword", true);
                playerAnim.SetFloat("speed", 6);
            }
            else
            {
                playerAnim.SetFloat("speed", 6);
            }
        }
    }

    
}
