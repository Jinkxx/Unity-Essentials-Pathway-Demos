using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-time seconds should one full in-game day take?")]
    public float dayLengthInSeconds = 120f;

    [Tooltip("Starting rotation offset, if you want the day to begin at a certain sun angle.")]
    public float startRotation = 0f;

    private float rotationSpeed;

    void Start()
    {
        // Calculate degrees per second (360° for one full rotation)
        rotationSpeed = 360f / dayLengthInSeconds;

        // Optionally set initial rotation
        transform.rotation = Quaternion.Euler(startRotation, 0f, 0f);
    }

    void Update()
    {
        // Rotate around the X-axis to simulate the sun's movement
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
