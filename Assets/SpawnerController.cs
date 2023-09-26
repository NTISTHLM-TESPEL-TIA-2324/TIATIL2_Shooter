using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

  [SerializeField]
  GameObject enemyPrefab;

  [SerializeField]
  float timeBetweenEnemies = 0.5f;
  float timeSinceLastEnemy = 0;

  void Update()
  {
    timeSinceLastEnemy += Time.deltaTime;

    if (timeSinceLastEnemy > timeBetweenEnemies)
    {
      Instantiate(enemyPrefab);
      timeSinceLastEnemy = 0;
    }
  }
}
