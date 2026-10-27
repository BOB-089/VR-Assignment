using UnityEngine;

public class BallBounceAudio : MonoBehaviour
{
    AudioSource audioSource;
    Rigidbody rb;
    [SerializeField] private float volume = 0.2f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(audioSource.clip, Mathf.Clamp01(volume * rb.linearVelocity.magnitude));
    }
}
