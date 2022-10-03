using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField]
    public AudioSource btnClick;

    void Start()
    {
        btnClick = GetComponent<AudioSource>();
    }
    
    public void Play()
    {
    
        btnClick.Play();
        
    }
}
