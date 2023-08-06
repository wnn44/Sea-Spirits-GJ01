using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private AudioSource _meowSound;
    
    public void WannaExit()
    {
        _meowSound.Play();
    }
}
