using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    public float period = 1f;
    public float amplitude = 1f;

    [Range(0, 1)]
    public float phase = 0f;

    private void Update()
    {
        var position = ((Time.time / period) + phase) * (2 * Mathf.PI);

        transform.Translate(0, amplitude * Mathf.Sin(position), 0, 0);
    }
}
