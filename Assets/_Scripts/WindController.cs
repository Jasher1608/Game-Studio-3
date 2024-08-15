using System.Collections;
using UnityEngine;

public class WindController : MonoBehaviour
{
    public Material windMaterial;
    public float minWindSpeed = 0.1f;
    public float maxWindSpeed = 1.0f;
    public float directionChangeInterval = 5.0f;
    public float speedChangeInterval = 3.0f;
    public float smoothness = 0.1f;

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
