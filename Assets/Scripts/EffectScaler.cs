using UnityEngine;
using System.Collections;

public class EffectScaler : MonoBehaviour
{

    public float amplitudeX = 10.0f;
    public float amplitudeY = 5.0f;
    public float omegaX = 1.0f;
    public float omegaY = 5.0f;
    private float index;
    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void Update()
    {
        index += Time.deltaTime;
        float x = amplitudeX * Mathf.Cos(omegaX * index);
        float y = Mathf.Abs(amplitudeY * Mathf.Sin(omegaY * index));
        transform.localPosition = new Vector3(x + originalPosition.x, y + originalPosition.y, 0 + originalPosition.z);
    }

}
