﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        LabelDefenderPrice();
    }

    // Show defender prices 
    private void LabelDefenderPrice()
    {
        TextMeshProUGUI priceText = GetComponentInChildren<TextMeshProUGUI>();
        // Get price of Defender
        priceText.text = defenderPrefab.GetStarPrice().ToString();
    }

    // On click of mouse
    private void OnMouseDown()
    {
        // Array of button objects in defender selector menu
        DefenderButton[] buttons = FindObjectsOfType<DefenderButton>();
        // Make the other items dark
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(34, 34, 34, 255);
        }
        // When clicked show the original color of clicked item
        GetComponent<SpriteRenderer>().color = Color.white;
        // Pass selected defender object to Setter function
        FindObjectOfType<DefenderSpawn>().SetSelectedDefender(defenderPrefab);
    }

}
