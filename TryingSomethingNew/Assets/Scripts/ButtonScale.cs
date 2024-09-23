using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalScale;
    public Vector3 hoverScale = new Vector3(1.2f, 1.2f, 1.2f);  // Butonun büyüme oranı

    void Start()
    {
        // Butonun başlangıç boyutunu kaydediyoruz
        originalScale = transform.localScale;
    }

    // Fare butona geldiğinde çağrılır
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = hoverScale;
    }

    // Fare butondan ayrıldığında çağrılır
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale;
    }
}
