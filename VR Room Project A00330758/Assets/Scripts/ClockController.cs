using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ClockController : MonoBehaviour
{
    [SerializeField] private Transform hoursHand;
    [SerializeField] private Transform minutesHand;
    [SerializeField] private Transform secondsHand;

    void Update()
    {
        DateTime currentTime = DateTime.Now;

        float seconds = currentTime.Second;
        float minutes = currentTime.Minute + seconds / 60f;
        float hours = (currentTime.Hour % 12) + minutes / 60f;

        secondsHand.localRotation = Quaternion.Euler(seconds * 6f + 90, 0, 0 -90);
        minutesHand.localRotation = Quaternion.Euler(minutes * 6f + 90, 0, 0 -90);
        hoursHand.localRotation = Quaternion.Euler(hours * 30f +90 , 0, 0 -90);
    }
}
