using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ProjectSaga
{
    public class GameManager : MonoBehaviour
    {
        public void PlayGame()
        {
            GUI.Instance.playButton();
        }

        public void Start()
        {
            SoundController.Instance.GeneralMusic();
        }
        
    }    
}

