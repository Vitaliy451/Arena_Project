using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] m_SpawnPoints;
    public GameObject m_EnemyPrefab1;
    public GameObject m_EnemyPrefab2;

    // Start is called before the first frame update
    void Start()
    {
        SpawnNewEnemy();
    }

    void OnEnable()
    {
        PlayerBullet.OnEnemyKilled += SpawnNewEnemy;
    }


    void SpawnNewEnemy()
    {

        int randomNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length - 1));

        if(randomNumber % 2 == 0) Instantiate(m_EnemyPrefab1, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity);
        else
        Instantiate(m_EnemyPrefab2, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity);


    }
}
