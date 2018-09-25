using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour {
    
    public float MoveHorizontalSpeed = 5f;
    public float MoveVerticalSpeed = 5f;
    private Rigidbody2D RigidBody;
    private float InputHorizontal;
    private float InputVertical;
    private Animator Anim;


    // Use this for initialization
    void Start () {
        RigidBody = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }
	
	// Fixed update called after all physics calculations processed 
	//void FixedUpdate () {
 //       if ((InputHorizontal = Input.GetAxisRaw("Horizontal")) !=0) 
 //       { 
 //           //RigidBody.velocity = new Vector2(InputHorizontal * Speed, RigidBody.velocity.y);
 //           //RigidBody.velocity = Vector2.right * InputHorizontal * Speed;
 //           RigidBody.AddForce(Vector2.right * InputHorizontal * Speed);
 //       }

 //       Debug.Log("Velocity=" + RigidBody.velocity + ", x=" + transform.position.x + ", y=" + transform.position.y);
 //   }

    //void FixedUpdate()
    //{
    //    if ((InputHorizontal = Input.GetAxisRaw("Horizontal")) != 0)
    //    {
    //        transform.Translate(Vector3.forward * InputHorizontal * MoveHorizontalSpeed);
    //    }

    //    if ((InputVertical = Input.GetAxisRaw("Vertical")) != 0)
    //    {
    //        transform.Translate(Vector3.up * InputVertical * MoveVerticalSpeed);
    //    }

    //    Debug.Log("Position=" + transform.position.ToString());
    //    //Debug.Log("Velocity=" + RigidBody.velocity + ", x=" + transform.position.x + ", y=" + transform.position.y);
    //}

    void Update()
    {
        if ((InputHorizontal = Input.GetAxisRaw("Horizontal")) != 0)
        {
            transform.Translate(Vector3.right * InputHorizontal * MoveHorizontalSpeed * Time.deltaTime);
            //TRIGGER ANIMATION
            if (InputHorizontal > 0)
            {
                Anim.SetTrigger("WalkRight");
            }
            else
            {
                Anim.SetTrigger("WalkLeft");
            }
        }

        if ((InputVertical = Input.GetAxisRaw("Vertical")) != 0)
        {
            transform.Translate(Vector3.up * InputVertical * MoveVerticalSpeed * Time.deltaTime);
        }

        Debug.Log("Position=" + transform.position.ToString());
        //Debug.Log("Velocity=" + RigidBody.velocity + ", x=" + transform.position.x + ", y=" + transform.position.y);
    }
}
