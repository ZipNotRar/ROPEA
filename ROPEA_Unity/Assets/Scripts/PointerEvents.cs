using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerEvents : MonoBehaviour, /* IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler,*/ IPointerClickHandler
{
    [SerializeField] private Color normalColor = Color.white;
    [SerializeField] private Color enterColor = Color.white;
    [SerializeField] private Color downColor = Color.white;
    [SerializeField] private UnityEvent OnClick = new UnityEvent();
    [SerializeField] private UnityEvent OnClick2 = new UnityEvent();
    [SerializeField] private bool isGameobjectDestroyed;
    private MeshRenderer meshRenderer = null;
    private void Awake()
    {
    meshRenderer = GetComponent<MeshRenderer>();
    }

    // public void OnPointerEnter(PointerEventData eventData)
    // {
    //     meshRenderer.material.color = enterColor;
    //     print("Enter");
    // }

    // public void OnPointerExit(PointerEventData eventData)
    // {
    //     meshRenderer.material.color = normalColor;
    //     print("Exit");
    // }

    // public void OnPointerDown(PointerEventData eventData)
    // {
    //     meshRenderer.material.color = downColor;
    //     print("Down");
    // }

    // public void OnPointerUp(PointerEventData eventData)
    // {
    //     meshRenderer.material.color = enterColor;
    //     print("Up");
    // }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick.Invoke();
        if (isGameobjectDestroyed && (this.enabled == false))
        {
            OnClick2.Invoke();
        }
    }
    

}
