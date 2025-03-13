using UnityEngine;

public class PlanetAnim : MonoBehaviour
{
    float degreePerSecond = 20;
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, degreePerSecond) * Time.deltaTime);
    }
}
