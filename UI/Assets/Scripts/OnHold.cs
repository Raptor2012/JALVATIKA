using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnHold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public ParticleSystem PS;
    private bool pointerDown;
    private float pointerDownTimer;

    [SerializeField]
    private float requiredHoldTime;
    public UnityEvent onLongClick;

     public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;

       
        

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
        PS.Stop();
      
    }

    private void Update()
    {
        if (pointerDown)
        {
            pointerDownTimer += Time.deltaTime;
            if (pointerDownTimer <= requiredHoldTime)
            {
                if (onLongClick != null)
                    onLongClick.Invoke();

            }
          }
    }

    private void Reset()
    {
        pointerDown = false;
        pointerDownTimer = 0;
      }

}
