using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class RecordPlayer : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor recordSocket;
    [SerializeField] private AudioSource audioSource;

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

        if (playing && !recordSocket.hasSelection)
        {
            playing = false;
            audioSource.Stop();
        }
    }
}