using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class AnimationController : MonoBehaviour
    {
        public Animator _Animator = default;
        private int _vertical;
        private int _horizontal;
        private int _ismoving;

        [SerializeField] private bool _rotationAllowed = default;

        public void Awake()
        {
            _Animator = GetComponent<Animator>();
            _vertical = Animator.StringToHash("Vertical");
            _horizontal = Animator.StringToHash("Horizontal");
            _ismoving = Animator.StringToHash("isMoving");
        }

        public void refreshAnimValues(float _verticalMovement, float _horizontalMovement)
        {
            #region Vertical
                float _vert = 0;

                if (_verticalMovement > 0 && _verticalMovement < 0.55f)
                {
                    _vert = 0.5f;
                }
                else if (_verticalMovement > 0.55f)
                {
                    _vert = 1;
                }
                else if (_verticalMovement < 0 && _verticalMovement > -0.55f)
                {
                    _vert = -0.5f;
                }
                else if (_verticalMovement < -0.55f)
                {
                    _vert = -1;
                }
                else
                {
                    _vert = 0;
                }

            #endregion

            #region Horizontal

            float _hori = 0;

            if (_horizontalMovement > 0 && _horizontalMovement < 0.55f)
            {
                _hori = 0.5f;
            }
            else if (_horizontalMovement > 0.55f)
            {
                _hori = 1;
            }
            else if (_horizontalMovement < 0 && _horizontalMovement > -0.55f)
            {
                _hori = -0.5f;
            }
            else if (_horizontalMovement < -0.55f)
            {
                _hori = -1;
            }
            else
            {
                _hori = 0;
            }

            #endregion
            
            #region Idle
            
                
            
            #endregion
        }

       
    }
}