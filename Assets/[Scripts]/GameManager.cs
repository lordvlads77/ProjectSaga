using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class GameManager : MonoBehaviour
    {
        /*public void PlayGame()
        {
            GUI.Instance.playButton();
        }*/

        public void Start()
        {
            SoundController.Instance.GeneralMusic();
        }
    }    
}

