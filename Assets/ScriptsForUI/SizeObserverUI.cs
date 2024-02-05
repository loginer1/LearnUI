using UnityEngine;
using UnityEngine.UI;

public class SizeObserverUI : MonoBehaviour
{
    [SerializeField] private RectTransform _observedElement;
    [SerializeField] private Vector2 _ofset;

    private RectTransform _myRectTransform;  

    void Start()
    {
        _myRectTransform = GetComponent<RectTransform>();

        if (_observedElement == null)
        {
            Debug.LogError("Не вказано елемент для спостереження!");
            return;
        }

        _myRectTransform.sizeDelta = _observedElement.sizeDelta + _ofset;
    }

    private void OnValidate()
    {
        _myRectTransform = GetComponent<RectTransform>();

        if (_observedElement == null)
        {
            Debug.LogError("Не вказано елемент для спостереження!");
            return;
        }

        _myRectTransform.sizeDelta = _observedElement.sizeDelta + _ofset;
    }

    void Update()
    {
        if (_observedElement.sizeDelta != _myRectTransform.sizeDelta)
        {
            _myRectTransform.sizeDelta = _observedElement.sizeDelta + _ofset;
        }
    }
}