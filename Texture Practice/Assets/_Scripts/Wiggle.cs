using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour {

    public float duration;
    public float magnitude;

    public void Update()
    {
        Shake();

    }

    IEnumerator Shake()
    {

        float elapsed = 0.0f;

        Vector3 originalPos = transform.position;

        while (elapsed < duration)
        {

            elapsed += Time.deltaTime;

            float percentComplete = elapsed / duration;
            float damper = 1.0f - Mathf.Clamp(4.0f * percentComplete - 3.0f, 0.0f, 1.0f);

            // map value to [-1, 1]
            float x = Random.value * 2.0f - 1.0f;
            float y = Random.value * 2.0f - 1.0f;
            x *= magnitude * damper;
            y *= magnitude * damper;

            transform.position = new Vector3(x, y, originalPos.z);

            yield return null;
        }

        transform.position = originalPos;
    }

}
