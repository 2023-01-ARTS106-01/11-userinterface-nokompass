using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemButton : MonoBehaviour
{
    private TextMeshProUGUI buttonText;
    private string[] itemTypes = { "Armor", "Weapon", "Spell" };
    public int typeIndex;

    // Start is called before the first frame update
    void Awake()
    {
        typeIndex = Random.Range(0, 3);
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = itemTypes[typeIndex];
    }

   
}
