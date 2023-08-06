using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public float rotationDegreesPerSecond = 45f;
    public float rotationDegreesAmount = 90f;
    private float totalRotation = 0;
    [SerializeField] public bool Open;
    void Update()
    {
        if (Mathf.Abs(totalRotation) < Mathf.Abs(rotationDegreesAmount) && Open)
            SwingOpen();
    }

    void SwingOpen()
    {
        float currentAngle = transform.rotation.eulerAngles.y;
        transform.rotation =
         Quaternion.AngleAxis(currentAngle + (Time.deltaTime * rotationDegreesPerSecond), Vector3.up);
        totalRotation += Time.deltaTime * rotationDegreesPerSecond;
    }
}
