using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace FH
{
  
    public class win1 : MonoBehaviour
    {
        public TextMeshProUGUI WINTEXT;

        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "WIN")
            {
                WINTEXT.gameObject.SetActive(true);
               

            }
        }
    }
}

