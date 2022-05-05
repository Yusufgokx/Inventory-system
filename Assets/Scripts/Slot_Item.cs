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

   
    void Update()
    {
        
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
