using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public List<Paddle> leftPaddles;
    public List<Paddle> rightPaddles;
    
    private PinballWizardsControls controls;
    
    void Awake()
    {
        controls = new PinballWizardsControls();
    }

    private void OnEnable()
    {
        controls.Enable();

        controls.Player.LeftPaddle.performed += HandleLeftPaddleInput;
        controls.Player.RightPaddle.performed += HandleRightPaddleInput;
    }

    private void OnDisable()
    {
        controls.Disable();
        
        controls.Player.LeftPaddle.performed -= HandleLeftPaddleInput;
        controls.Player.RightPaddle.performed -= HandleRightPaddleInput;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void HandleLeftPaddleInput(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() > 0.5f)
        {
            foreach (Paddle paddle in leftPaddles)
            {
                paddle.Flip();
            }
        }
        else
        {
            foreach (Paddle paddle in leftPaddles)
            {
                paddle.Reset();
            }
        }
    }

    private void HandleRightPaddleInput(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() > 0.5f)
        {
            foreach (Paddle paddle in rightPaddles)
            {
                paddle.Flip();
            }
        }
        else
        {
            foreach (Paddle paddle in rightPaddles)
            {
                paddle.Reset();
            }
        }
    }
}
