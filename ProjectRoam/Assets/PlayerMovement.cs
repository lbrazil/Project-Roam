﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    StateMachine stateMachine = new StateMachine();

    public float Speed = 5.0f;

    public float RotationSpeed = 240.0f;

    private float Gravity = 20.0f;

    private Vector3 _moveDir = Vector3.zero;

    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get Input for axis
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Calculate the forward vector
        Vector3 camForward_Dir = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 move = v * camForward_Dir + h * Camera.main.transform.right;

        if (move.magnitude > 1f) move.Normalize();

        // Calculate the rotation for the player
        move = transform.InverseTransformDirection(move);

        // Get Euler angles
        float turnAmount = Mathf.Atan2(move.x, move.z);

        transform.Rotate(0, turnAmount * RotationSpeed * Time.deltaTime, 0);

        _moveDir = transform.forward * move.magnitude;

        _moveDir *= Speed;

        _moveDir.y -= Gravity * Time.deltaTime;

        _characterController.Move(_moveDir * Time.deltaTime);
        //transform.Translate(_moveDir * Time.deltaTime);
    }
}
