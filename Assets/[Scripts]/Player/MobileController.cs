using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class MobileController : MonoBehaviour
    {
        [SerializeField] private PlayerActions _playerActions = default;
        private CharacterController controller;
        // player velocity handles the ability to jump by setting it to 0
        private Vector3 playerVelocity;
        private bool groundedPlayer;
        [SerializeField] private float playerSpeed = 2.0f;
        [SerializeField] private float jumpHeight = 1.0f;
        [SerializeField] private float gravityValue = -9.81f;
    
        private void Awake()
        {
            _playerActions = new PlayerActions();
            controller = GetComponent<CharacterController>();
        }
    
        private void OnEnable()
        {
            _playerActions.Enable();
        }
    
        private void OnDisable()
        {
            _playerActions.Disable();
        }
    
        void Update()
        {
            /*this makes sure the player y axis is 0, and also tells the game the player is grounded
             if the axis is less than 0*/
            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
            }
    
            Vector2 _inputMovement = _playerActions.PlayerMoves.Move.ReadValue<Vector2>();
            Vector3 move = new Vector3(_inputMovement.y, 0f, _inputMovement.x);
            controller.Move(move * Time.deltaTime * playerSpeed);
    
            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
                AnimationController.Instance.Moving();
            }
    
            if (move == Vector3.zero)
            {
                AnimationController.Instance.notMoving();
            }
    
            // Changes the height position of the player..
            //This enables the player to jump
            if (_playerActions.PlayerMoves.Jump.triggered && groundedPlayer)
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }
    
            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);
        }
    }    
}

