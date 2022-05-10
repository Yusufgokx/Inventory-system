using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot_Item : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Item itemTable;
    public Image mainIcon;
    public GameObject explanationCanvas;
    public Text Explanation;

    void Start()
    {
        explanationCanvas.SetActive(false);
        mainIcon.sprite = itemTable.itemImage;

    }

    public void UseItem()
    {
        Debug.Log(itemTable.itemName + "Ýsimli Ýtem Kullanýldý");
    }

    public void DeleteItem()
    {
        Debug.Log(itemTable.itemName + "Ýsimli Ýtem Silindi");
        Destroy(gameObject);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        explanationCanvas.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        explanationCanvas.SetActive(false);
    }
}
