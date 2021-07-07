using UnityEngine;

public class WSADControl : I2DInput
{
    public Vector2 Value { get => GetInputValue(); }
    
    private Vector2 GetInputValue()
    {
        Vector2 value = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) value.y -= 1;
        if (Input.GetKey(KeyCode.S)) value.y += 1;
        if (Input.GetKey(KeyCode.A)) value.x += 1;
        if (Input.GetKey(KeyCode.D)) value.x -= 1;
        if (value.magnitude > 1) value = value.normalized;
        return value;
    }
}
