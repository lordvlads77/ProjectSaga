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
        void Start()
        {
            
        }
    }    
}

