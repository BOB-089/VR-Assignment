using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ShowToolTips : MonoBehaviour
{
    [SerializeField] private GameObject toolTip1;
    [SerializeField] private GameObject toolTip2;
    [SerializeField] private NearFarInteractor leftHand;
    [SerializeField] private NearFarInteractor rightHand;
    [SerializeField] private XRSocketInteractor headSocket;
    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered: " + other.name);
        if (other.tag == "Player" && !activated)
        {
            toolTip1.SetActive(true);
            activated = true;
        }
    }

    void Update()
    {
        if ((rightHand.hasSelection && rightHand.firstInteractableSelected.transform.CompareTag("Hat")) || (leftHand.hasSelection && leftHand.firstInteractableSelected.transform.CompareTag("Hat")))
        {
            activated = true;
            toolTip1.SetActive(false);
            toolTip2.SetActive(true);
        }

        if(headSocket.hasSelection)
        {
            toolTip1.SetActive(false);
            toolTip2.SetActive(false);
        }
    }
}