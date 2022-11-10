using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace FH
{

    public class Player1 : MonoBehaviour
    {
        public EnemySpawner enemySpawner;
        public TextMeshProUGUI countDownText;

        public float speed;
        int enemiesKilled;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);
                enemiesKilled++;
                if (enemiesKilled == enemySpawner.GetNumberOfEnemies())
                {
                    //show that we won

                    countDownText.text = "You Won!";
                    Time.timeScale = 0;
                }
            }
        }


    }
}
