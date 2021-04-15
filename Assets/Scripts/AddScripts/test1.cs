using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{

    private Terminal bluetoothMgr, bluetoothMgr2;

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
        if(collision.gameObject.name == "Sphere")
        {
            //블루투스 데이터 전송
            bluetoothMgr.OffSendData1();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
            //블루투스 데이터 전송
            bluetoothMgr.SendData1();
        }
    }
}