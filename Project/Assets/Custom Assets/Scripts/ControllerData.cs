using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControllerData : MonoBehaviour
{
    public InputDevice handL, handR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!handL.isValid || !handR.isValid)
        {
            SetUpDevices();
        }
    }

    void SetUpDevices()
    {
        if (!handL.isValid)
        {
            InitializeInputDevices(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Left, ref handL);
        }
        if (!handR.isValid)
        {
            InitializeInputDevices(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Right, ref handR);
        }
    }

    void InitializeInputDevices(InputDeviceCharacteristics c, ref InputDevice device)
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(c, devices);
        if (devices.Count > 0) device = devices[0];
    }
}
