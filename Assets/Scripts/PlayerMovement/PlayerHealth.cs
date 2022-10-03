using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{  
    [SerializeField]
    GameObject deathScreen;

    [SerializeField]
    Text healthInfo;

    public int health = 100;

    void Update()
    {
        if (health < 0) health = 0;
        if(health <= 0)
        {
            deathScreen.SetActive(true);
        }
        healthInfo.text = health + "";
    }
    public void Damage()
    {
        health -= 15;
        Debug.Log(health);
    }
}
