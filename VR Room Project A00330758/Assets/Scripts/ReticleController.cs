using UnityEngine;

public class ReticleController : MonoBehaviour
{
    private bool grow = true;

    [SerializeField] private float growTime = 2f;
    [SerializeField] private float scaleSpeed = 1f;

    private float timeGrowing = 0f;

    void Update()
    {
        this.transform.Rotate(0f, 50f * Time.deltaTime, 0f);
        timeGrowing += Time.deltaTime;
        if (grow)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
            if (timeGrowing >= growTime) { grow = false; timeGrowing = 0f; }
        }
        else
        {
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
            if (timeGrowing >= growTime) { grow = true; timeGrowing = 0f; }
        }
    }
}
