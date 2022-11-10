using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FH
{
    public class EnemySpawner : MonoBehaviour
    {

        int numberOfEnemies = 20;

        public int GetNumberOfEnemies()
        {
            return numberOfEnemies;
        }
    }
}
