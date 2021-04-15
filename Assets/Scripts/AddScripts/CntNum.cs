using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CntNum : MonoBehaviour
{
    private SteamVR_Controller.Device device, hipsDevice, lfootDevice, rfootDevice;

    static public int num = 0;
    static public float cntTime = 0;
    static public bool chkCollTime = false;
    static public bool totalTrackerColTimeChk = false;

    private bool bottonChk = false;

    public Text cntText;
    public Text cntTimeText;

    public GameObject hips, rFoot, lFoot;

    private float hipsDistance, rFootDistance, lFootDistance;

    // Start is called before the first frame update
    void Start()
    {
        cntText.text = "";
        cntTimeText.text = "";
        device = SteamVR_Controller.Input(6);
        hipsDevice = SteamVR_Controller.Input(5);
        lfootDevice = SteamVR_Controller.Input(8);
        rfootDevice = SteamVR_Controller.Input(7);
    }

    // Update is called once per frame
    void Update()
    {
        if (/*totalTrackerColTimeChk ||*/ bottonChk)
        {
            CntNum.cntTime += Time.deltaTime;
        }
        if(cntTime != 0)
        {
            cntTimeText.text = "걸린시간 : " + cntTime.ToString("N2");
        }

        if (TrackerCollision.trackerColTimeChk > 1.0f && TrackerCollision1.trackerColTimeChk > 1.0f && TrackerCollision2.trackerColTimeChk > 1.0f)
        {
            if(cntTime > 1)
            {
                //Debug.Log(cntTime);
                //cntTimeText.text = "걸린시간 : " + (cntTime - 1);
                //CntNum.cntTime = 0;
            }
            //totalTrackerColTimeChk = true;
            //CntNum.num = 0;
            //CntNum.cntTime = 0;
        }
        //Debug.Log(num);
        //Debug.Log(cntTime);
        cntText.text = "틀린횟수 : " + num;

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            if (bottonChk == false)
            {
                bottonChk = true;
                chkCollTime = false;
            }
            else
            {
                //Debug.Log("좌표 : " + rFoot.transform.position + "   --   " + lfootDevice.transform.pos);
                //각 트래커 위치에서 큐브사이의 거리를 측정후 출력
                hipsDistance = Vector3.Distance(hips.transform.position, hipsDevice.transform.pos);
                rFootDistance = Vector3.Distance(rFoot.transform.position, rfootDevice.transform.pos);
                lFootDistance = Vector3.Distance(lFoot.transform.position, lfootDevice.transform.pos);

                Debug.Log("걸린시간 : " + cntTime.ToString("N2") + "hipsDistance : " + hipsDistance * 100 + "  rFootDistance : " + rFootDistance * 100 + "  lFootDistance : " + lFootDistance * 100 + "틀린횟수 : " + num);

                cntTimeText.text = "걸린시간 : " + cntTime.ToString("N2");
                bottonChk = false;
                cntTime = 0;
                num = 0;
            }
                
        }
    }
}
