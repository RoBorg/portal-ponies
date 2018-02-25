using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jiggle : MonoBehaviour
{
    public float period = 1f;
    public float xAmplitude = 0f;
    public float yAmplitude = 1f;
    public float zAmplitude = 0;

    [Range(0, 1)]
    public float phase = 0f;

    private void Update()
    {
        var position = ((Time.time / period) + phase) * (2 * Mathf.PI);

        transform.Rotate(xAmplitude * Mathf.Sin(position), yAmplitude * Mathf.Sin(position), zAmplitude * Mathf.Sin(position));
    }
}
