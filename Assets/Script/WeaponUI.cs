using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class WeaponUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentBulletsText, maxBulletsText;

    public static WeaponUI Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void UpdateCurrentBullets(int currentBulletss)
    {
        currentBulletsText.text = currentBulletss.ToString();

        if(currentBulletss <= 0)
            currentBulletsText.color = Color.red;
        else
            currentBulletsText.color = Color.white;
    }

    public void UpdateMaxBullets(int maxBullets)
    {
        maxBulletsText.text = maxBullets.ToString();
    }

    public void EnableWeaponUI(bool State)
    {
        gameObject.SetActive(State);
    }
}
