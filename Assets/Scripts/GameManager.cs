using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    TextMeshProUGUI materials;
    // Start is called before the first frame update
    void Start()
    {
        materials = GameObject.Find("Material Counter").GetComponent<TextMeshProUGUI>();
        InvokeRepeating("updateStone", 0, 1);
    }

    void updateStone()
    {
        int activeMiners = GameObject.FindGameObjectsWithTag("Miner").Length;
        int currentStoneAmount = Int32.Parse(materials.text.Substring(6));

        materials.text = materials.text.Substring(0, 7) + (currentStoneAmount + activeMiners);
    }
}
