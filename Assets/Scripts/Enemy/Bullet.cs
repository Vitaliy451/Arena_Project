using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
   void Awake()
   {
      StartCoroutine(DestroyBulletAfterTime());
   }

    IEnumerator DestroyBulletAfterTime()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        PlayerHealth ph = collision.gameObject.GetComponent<PlayerHealth>();
        
        if (ph && ph.health > 0)
        {
            ph.Damage();
            Debug.Log("Damage given");
            Destroy(gameObject);
        }   
       
    }

    
}
