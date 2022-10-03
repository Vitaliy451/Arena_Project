using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBullet : MonoBehaviour
{
    /*
    [SerializeField]
    Text enemyStats;
    [SerializeField]
    Text bombStats;
    [SerializeField]
    Text shotsStats;

    int killCount = 0;
    int destroyedBomb = 0;
    int shotsFired = 0;
    */

    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKilled;

    void Awake()
    {
        StartCoroutine(DestroyBulletAfterTime());
    }
    IEnumerator DestroyBulletAfterTime()
    {
        yield return new WaitForSeconds(1.5f);
  
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Enemy")
            && gameObject != null)
        {
           
            Destroy(collision.gameObject);
            if (OnEnemyKilled != null)
            {
                OnEnemyKilled();
            }
        }
        if(collision.gameObject.tag == "Bomb")
        {
            
            Destroy(collision.gameObject);
        }

    }
}
