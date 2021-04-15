using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideScale : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;
    public GameObject mainChar;
    private Transform mainCharTrans;

    private Terminal bluetoothMgr, bluetoothMgr1;

    static public bool xbotBool = false;
    private bool testtt = true;
    // Start is called before the first frame update
    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        device = SteamVR_Controller.Input(5);
        bluetoothMgr = GameObject.Find("BluetoothMgr").GetComponent<Terminal>();
    }

    // Update is called once per frame
    void Update()
    {
        if (testtt)
        {
            //this.transform.position = mainChar.transform.position;
            this.transform.localScale = mainChar.transform.localScale;
            
        }


        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            //this.GetComponent<Animator>().enabled = true;
            testtt = false;

            xbotBool = true;
        }
        if (device.GetPress(SteamVR_Controller.ButtonMask.Grip))
        {
            //블루투스 연결
            bluetoothMgr.Connect(false);
        }
    }
}
