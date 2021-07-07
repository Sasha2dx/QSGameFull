using UnityEngine;

public class SumControl : I2DInput
{
    public Vector2 Value { get => GetInputValue(); }
    private I2DInput[] _inputs;

    public SumControl(I2DInput[] inputs)
    {
        _inputs = inputs;
    }

    private Vector2 GetInputValue()
    {
        var value = Vector2.zero;
        foreach (var input in _inputs) value += input.Value;
        if (value.magnitude > 1) value = value.normalized;
        return value;
    }

}
