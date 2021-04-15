﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerCollision1 : MonoBehaviour
{
    static public float trackerColTimeChk;

    private GameObject childTrack;
    private GameObject parTracker;
    private int index;

    public GameObject chkCube;

    private Terminal bluetoothMgr;

    // Start is called before the first frame update
    void Start()
    {
        bluetoothMgr = GameObject.Find("BluetoothMgr").GetComponent<Terminal>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Tracker(Clone)")
        {
            //Debug.Log("일치");
            
            GetComponent<MeshRenderer>().material.color = Color.green;
            bluetoothMgr.OffSendData1();
            trackerColTimeChk += Time.deltaTime;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Tracker(Clone)")
        {
            //Debug.Log("나옴");
            
            GetComponent<MeshRenderer>().material.color = Color.red;
            //블루투스 데이터 전송
            bluetoothMgr.SendData1();
            //틀린횟수 증가
            CntNum.num++;
            trackerColTimeChk = 0;
        }
    }
}