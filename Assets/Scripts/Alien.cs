using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{

    public int scoreValue;
    public GameObject exp;
    public GameObject coinPrefab;
    public GameObject lifePrefab;
    public GameObject healthPrefab;

    private const int LIFE_CHANGE = 1;
    private const int HEALTH_CHANGE = 10;
    private const int COIN_CHANGE = 500;

    public void Kill()
    {
        UIManager.UpdateScore(scoreValue);
        AlienMaster.allAliens.Remove(gameObject);
        Instantiate(exp, transform.position, Quaternion.identity);


        int ran = Random.Range(0, 1000);

        if(ran <= LIFE_CHANGE)
        {
            Instantiate(lifePrefab, transform.position, Quaternion.identity);
        }
        else if (ran <= HEALTH_CHANGE)
        {
            Instantiate(healthPrefab, transform.position, Quaternion.identity);
        }
        else if (ran <= COIN_CHANGE)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }



        if (AlienMaster.allAliens.Count == 0)
        {
            GameManager.SpawnNewWave();
        }

        gameObject.SetActive(false);
    }
}
