using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float defaultspeed = 10;
    public bool isTouchingWater = false;

    private float walkspeed;
    private CharacterController controller;
    private Rigidbody rb;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        walkspeed = defaultspeed;
    }

    void Update()
    {
    Vector3 movement = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
    movement = transform.rotation * movement * Time.deltaTime * walkspeed;
    controller.Move(movement);

    if (Input.GetKey(KeyCode.LeftShift) && walkspeed == defaultspeed)
    {
        walkspeed = walkspeed * 2;
    } else {
        walkspeed = defaultspeed;
    }
    
    if (Input.GetMouseButton(1) && isTouchingWater == false)
    {
        float mouseX = Input.GetAxis("Mouse X");
        this.transform.Rotate(Vector3.up * mouseX);
    } else {
        //Player is swimming, requires diffrent controls
    }
    }
}
