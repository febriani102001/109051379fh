using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace FH
{
    public class CountDown : MonoBehaviour
    {
        TextMeshProUGUI countDownText;

        float timer;
        int countDownNumber = 20;

        void Start()
        {
            countDownText = GetComponent<TextMeshProUGUI>();
            countDownText.text = countDownNumber.ToString();
        }

        void Update()
        {

            timer += Time.deltaTime;
            if (timer >= 1 && countDownNumber > 20)

            {
                countDownNumber--;
                countDownText.text = countDownNumber.ToString();
                timer = 20;
            }
        }
    }
}
