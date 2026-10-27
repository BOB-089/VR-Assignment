using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class RecordPlayer : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor recordSocket;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Transform handle;
    [SerializeField] private float rotateSpeed = 50f;

    private bool playing;

    private void Update()
    {
        if (!playing && recordSocket.hasSelection)
        {
            Record record = recordSocket.firstInteractableSelected.transform.GetComponent<Record>();
            playing = true;
            audioSource.clip = record.song;
            audioSource.Play();
        }

        if(playing)
        {
            recordSocket.transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
            handle.localRotation = Quaternion.Euler(0, 60, 0);
        }
        else
        {
            handle.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (playing && !recordSocket.hasSelection)
        {
            playing = false;
            audioSource.Stop();
        }
    }
}