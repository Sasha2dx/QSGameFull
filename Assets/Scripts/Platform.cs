using UnityEngine;

public class Platform : MonoBehaviour
{
    public I2DInput Input { get; set; }
    public float MaxAngle { get; set; }

    private void Update()
    {
        var iv = Input.Value;
        transform.localEulerAngles = new Vector3(iv.y * MaxAngle, 0, -iv.x * MaxAngle);
    }
}
