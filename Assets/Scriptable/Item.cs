using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="DefaultItem",menuName ="Item/Create New Item")]

public class Item : ScriptableObject
{
    public string itemName = "Item Name";
    public Sprite itemImage;
    public string itemExplanation;
}
