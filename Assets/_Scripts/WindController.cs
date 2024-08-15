using System.Collections;
using UnityEngine;

public class WindController : MonoBehaviour
{
    public Material windMaterial; // The material with the shader using "_PoisonNoiseSpeed"
    public float minWindSpeed = 0.1f; // Minimum wind speed
    public float maxWindSpeed = 1.0f; // Maximum wind speed
    public float directionChangeInterval = 5.0f; // How often the wind direction changes (in seconds)
    public float speedChangeInterval = 3.0f; // How often the wind speed changes (in seconds)
    public float smoothness = 0.1f; // How smoothly the wind changes (lower values are smoother)

    private Vector2 currentWindSpeed;

    void Start()
    {
        StartCoroutine(UpdateWind());
    }

    private IEnumerator UpdateWind()
    {
        while (true)
        {
            // Randomize target wind speed and direction
            float targetWindSpeedMagnitude = Random.Range(minWindSpeed, maxWindSpeed);
            Vector2 targetWindDirection = Random.insideUnitCircle.normalized;
            Vector2 targetWindSpeed = targetWindDirection * targetWindSpeedMagnitude;

            // Smoothly transition to the new wind speed and direction
            float elapsedTime = 0f;
            Vector2 initialWindSpeed = currentWindSpeed;

            while (elapsedTime < directionChangeInterval)
            {
                elapsedTime += Time.deltaTime;

                // Smooth interpolation for speed and direction
                float t = Mathf.SmoothStep(0f, 1f, elapsedTime / directionChangeInterval);
                currentWindSpeed = Vector2.Lerp(initialWindSpeed, targetWindSpeed, t);

                windMaterial.SetVector("_PoisonNoiseSpeed", currentWindSpeed);
                yield return null;
            }

            // Wait before changing the wind direction and speed again
            yield return new WaitForSeconds(Random.Range(speedChangeInterval, directionChangeInterval));
        }
    }
}
