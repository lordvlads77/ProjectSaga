using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private float _horizontalaxis = default;
        [SerializeField] private float _verticalaxis = default;
        [SerializeField] private float _moveAmount = default;
        [SerializeField] private float _mouseX = default;
        [SerializeField] private float _mouseY = default;

        [Header("Input Sys Stuff")]
        private PlayerControls _inputActions;

        private Vector2 _movementInput = default;
        private Vector2 _camaraInput = default;

        public void OnEnable()
        {
            if (_inputActions == null)
            {
                _inputActions = new PlayerControls();
                _inputActions.playerMovement.Movement.performed +=
                    _inputActions => _movementInput = _inputActions.ReadValue<Vector2>();
                _inputActions.playerMovement.Camera.performed += i => _camaraInput = i.ReadValue<Vector2>();
            }
            _inputActions.Enable();
        }

        private void OnDisable()
        {
            _inputActions.Disable();
        }
        public void InputUpdate(float delta)
        {
            PlayerMoves(delta);
        }
        private void PlayerMoves(float delta)
        {
            _horizontalaxis = _movementInput.x;
            _verticalaxis = _movementInput.y;
            _moveAmount = Mathf.Clamp01(Mathf.Abs(_horizontalaxis) + Mathf.Abs(_verticalaxis));
            _mouseX = _camaraInput.x;
            _mouseY = _camaraInput.y;
        }
    }

}
