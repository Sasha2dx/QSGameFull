using UnityEngine;

public class SmoothInput : I2DInput
{
    public Vector2 Value => GetInputValue();
    private float _maxSpeed;
    private Vector2 _value;
    private I2DInput _targetInput;
    
    public SmoothInput(float maxSpeed, I2DInput input)
    {
        _maxSpeed = maxSpeed;
        _targetInput = input;
    }
    
    private Vector2 GetInputValue()
    {
        _value = Vector2.MoveTowards(_value, -_targetInput.Value, _maxSpeed*Time.deltaTime);
        return _value;
    }
}
