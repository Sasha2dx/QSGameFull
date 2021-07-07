using UnityEngine;
using UnityEngine.EventSystems;

public class TouchJoystick : UIBehaviour, I2DInput, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Vector2 Value
    {
        get => GetInputValue();
    }

    private bool _pointerDown;
    private Vector2 _touchStart;
    private Vector2 _curTouchPos;
    private float _fullSwipeLenght;

    protected override void Start()
    {
        CalcFullSwipeLength();
    }

    private Vector2 GetInputValue()
    {
        if (!_pointerDown) return Vector2.zero;
        Vector2 value = new Vector2(
            (_touchStart.x - _curTouchPos.x) / _fullSwipeLenght,
            (_touchStart.y - _curTouchPos.y) / _fullSwipeLenght
        );
        if (value.magnitude > 1) value = value.normalized;
        return value;
    }


    public void OnDrag(PointerEventData eventData)
    {
        _curTouchPos = eventData.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!_pointerDown)
        {
            _pointerDown = true;
            _touchStart = eventData.pressPosition;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _pointerDown = false;
    }

    protected override void OnRectTransformDimensionsChange()
    {
        CalcFullSwipeLength();
    }

    private void CalcFullSwipeLength()
    {
        var screenW = Screen.width;
        var screenH = Screen.height;
        var ratio = screenW / (float) screenH;
        _fullSwipeLenght = ratio < 0.7f ? screenW * 0.4f : screenH * 0.7f * 0.4f;
    }
}