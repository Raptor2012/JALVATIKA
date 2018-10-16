using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag_Drop : MonoBehaviour, IDragHandler, IEndDragHandler
{


    public Image PH;
    public Sprite PHPaper; 

    public void awake ()
    {
        PH = GetComponent<Image>();
    }
        
        
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        PH.gameObject.SetActive(true);
        PH.sprite = PHPaper;
        
        }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = new Vector3(-435, 200, 0);
        
        
    }
}
