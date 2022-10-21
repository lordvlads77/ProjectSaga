using UnityEngine;
using UnityEngine.SceneManagement;

namespace ProjectSaga
{
    public class GUI : MonoBehaviour
    {
        public static GUI Instance { get; private set; }
        [Header("GUI Screens")]
        [SerializeField] private GameObject _playScreen = default;
        [SerializeField] private GameObject _pauseScreen = default;
        [SerializeField] private GameObject _saveScreen = default;
        [SerializeField] private GameObject _deathScreen = default;
        [SerializeField] private GameObject _ingamePscreen = default;
        [SerializeField] private GameObject _saved = default;
        [SerializeField] private GameObject _loaded = default;

        private void Awake()
        {
            Instance = this;
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            Time.timeScale = 0;
        }

        public void playButton()
        {
            _playScreen.SetActive(false);
            _ingamePscreen.SetActive(true);
            Time.timeScale = 1;
        }

        public void pause()
        {
            _ingamePscreen.SetActive(false);
            _pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }

        public void deathScreen()
        {
            _deathScreen.SetActive(true);
        }

        public void Notpause()
        {
            _pauseScreen.SetActive(false);
            _ingamePscreen.SetActive(true);
            Time.timeScale = 1;
        }

        public void SaveGame()
        {
            _pauseScreen.SetActive(false);
            _saveScreen.SetActive(true);
        }

        public void Saved()
        {
            _saveScreen.SetActive(false);
            _saved.SetActive(true);
            
        }

        public void Loaded()
        {
            _saveScreen.SetActive(false);
            _loaded.SetActive(true);
        }

        public void secondwind()
        {
            SceneManager.LoadScene(0);
        }
    }   
}
