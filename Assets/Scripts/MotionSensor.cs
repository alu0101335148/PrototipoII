using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionSensor : MonoBehaviour
{
    public delegate void MotionDetectedEvent(string roomName);
    public static event MotionDetectedEvent OnMotionDetected;
    public CharacterController player;
    public string roomName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        OnMotionDetected(roomName);
    }
}
