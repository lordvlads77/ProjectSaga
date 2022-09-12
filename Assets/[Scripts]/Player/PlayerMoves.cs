using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class PlayerMoves : MonoBehaviour
    {
        private Transform _mainCamera = default;
        private InputController _inputController = default;
        private Vector3 _moveDirection = default;

        [HideInInspector]
        public Transform _transform = default;

        public Rigidbody rigi = default;
        public GameObject normalCamera = default;
        
        [Header("Stats")]
        [SerializeField] float _moveSpeed = default;
        [SerializeField] private float _speedRotation = default;
        
        [Header("Movement")]
        private Vector3 _normalVector = default;
        private Vector3 _targetPos = default;
        
        void Start()
        {
            rigi = GetComponent<Rigidbody>();
            _inputController = GetComponent<InputController>();
            _mainCamera = Camera.main.transform;
            _transform = transform;
            
        }

        private void Update()
        {
            float delta = Time.deltaTime;
            
            _inputController.InputUpdate(delta);
            _moveDirection = _mainCamera.forward * _inputController._verticalaxis;
            _moveDirection += _mainCamera.right * _inputController._horizontalaxis;
            _moveDirection.Normalize();

            float _speed = _moveSpeed;
            _moveDirection *= _speed;

            Vector3 _velocityPredict = Vector3.ProjectOnPlane(_moveDirection, _normalVector);
        }

        #region Movement

        void HandleRot(float delta)
        {
            Vector3 _targetDir = Vector3.zero;
            float _moveOveride = _inputController._moveAmount;

            _targetDir = _mainCamera.forward * _inputController._verticalaxis;
            _targetDir += _mainCamera.right * _inputController._horizontalaxis;
            _targetDir.y = 0;

            if (_targetDir == Vector3.zero)
                _targetDir = _transform.forward;

            float _rotationS = _speedRotation;
            
            Quaternion _targetRot = Quaternion.LookRotation(_targetDir);
            Quaternion _targetRotat = Quaternion.Slerp(_transform.rotation, _targetRot, _rotationS * delta);

            _transform.rotation = _targetRot;
        }

        #endregion
    }    
}

