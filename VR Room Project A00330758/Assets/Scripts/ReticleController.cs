using UnityEngine;

public class ReticleController : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate( 0f, 50f * Time.deltaTime, 0f);
    }
}
