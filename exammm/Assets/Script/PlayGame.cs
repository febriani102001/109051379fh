using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FH
{

  
    public class PlayGame : MonoBehaviour
    {
        [SerializeField] private AudioSource playEffect;
        public void PlayButton()
        {
            SceneManager.LoadScene("Third");
            playEffect.Play();
        }

    }
}
