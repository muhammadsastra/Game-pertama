﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HeartManager : MonoBehaviour
{

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halFullHeart;
    public Sprite empetyHeart;
    public FloatValue heartContainer;
    public FloatValue playerCurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        InitHearth();
        
    }
    public void InitHearth()
    {
        for (int i = 0; i < heartContainer.initialValue; i++)
        {
            hearts[i].gameObject.SetActive(true);
            hearts[i].sprite = fullHeart;
        }
    }
    public void UpdateHearts()
    {
        float tempHealth = playerCurrentHealth.RuntimeValue / 2;
        for (int i = 0; i < heartContainer.initialValue; i++)
        {
            if(i < tempHealth-1)
            {
                hearts[i].sprite = fullHeart;
            }else if ( i >= tempHealth)
            {
                hearts[i].sprite = empetyHeart;

            }else{
                hearts[i].sprite = halFullHeart;
            }
        }
    }
}
