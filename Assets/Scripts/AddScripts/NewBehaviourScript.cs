using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    SteamVR_TrackedObject trackedObj;
    //public SteamVR_Controller.Device device;
    public bool trigger;
    public bool trackpad;
    public bool grip;
    public bool menu;
    

    void Awake()
    {
        //device = SteamVR_Controller.Input(1);
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        //device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    void FixedUpdate()
    {
        //device = SteamVR_Controller.Input((int)trackedObj.index);
        //Debug.Log(device);
    }

    void Update()
    {
        var device = SteamVR_Controller.Input(1);
        Debug.Log(device);
        //device.TriggerHapticPulse(4000);
        //rumbleController();

        trigger = device.GetPress(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger);
        grip = device.GetPress(Valve.VR.EVRButtonId.k_EButton_Grip);
        trackpad = device.GetPress(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
        menu = device.GetPress(Valve.VR.EVRButtonId.k_EButton_ApplicationMenu);

        //test = device.GetPress(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger);

        //Debug.Log(test);
    }

    //void rumbleController()
    //{
    //    if (device.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
    //    {
    //        Debug.Log("진동");
    //        device.TriggerHapticPulse(1000);
    //    }
    //}
}
