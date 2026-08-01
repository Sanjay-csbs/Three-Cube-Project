using UnityEngine;

public class ContinuousRotation : MonoBehaviour
{
    [Header("Rotation Speeds (Degrees per second)")]
    [Tooltip("Rotation speed around the X axis.")]
    public float xSpeed = 0f;

    [Tooltip("Rotation speed around the Y axis.")]
    public float ySpeed = 50f;

    [Tooltip("Rotation speed around the Z axis.")]
    public float zSpeed = 0f;

    void Update()
    {
        // Multiply by Time.deltaTime to ensure frame-rate independent rotation speed
        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
    }
}