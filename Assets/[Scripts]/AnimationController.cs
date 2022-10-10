using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class AnimationController : MonoBehaviour
    {
        public static AnimationController Instance { get; private set; }
        public Animator _animator = default;
        private readonly int _isMov = Animator.StringToHash("isMoving");

        public void Awake()
        {
            
        }

        public void Moving()
        {
            _animator.SetBool("isMoving", true);
        }

        public void notMoving()
        {
            _animator.SetBool("isMoving", false);
        }

       

       
    }
}