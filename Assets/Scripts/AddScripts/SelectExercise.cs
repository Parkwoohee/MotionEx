using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectExercise : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;

    Animator guideAnimator, trAnimaotr;
    public GameObject trAni;

    public GameObject guideBotObj;

    public GameObject guideBotObj2;
    // Start is called before the first frame update
    void Start()
    {
        device = SteamVR_Controller.Input(5);
        guideBotObj = GameObject.Find("xbot");
        guideAnimator = guideBotObj.GetComponent<Animator>();
        trAnimaotr = trAni.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GuideScale.xbotBool)
        {
           
            GuideScale.xbotBool = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "laser(Clone)")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "laser(Clone)")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "laser(Clone)")
        {
            if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
            {
                //이전 cntTime 출력
                //Debug.Log("이전 cntTime" + CntNum.cntTime);
                //타이머관련
                CntNum.chkCollTime = true;
                CntNum.cntTime = 0;
                CntNum.num = 0;
                //가이드 및 트레이너 애니메이션 변경
                if (this.gameObject.name == "squat")
                    SqAnimator();
                else if (this.gameObject.name == "runge_L")
                    RungeAnimator_L();
                else if (this.gameObject.name == "runge_R")
                    RungeAnimator_R();
                else if (this.gameObject.name == "bridge")
                    BridgeAnimator();
            }
        }
    }
    private void SqAnimator()
    {
        guideBotObj2.SetActive(false);
        guideAnimator.SetInteger("controll",1);
        trAnimaotr.SetInteger("tr_controll", 1);
    }
    private void RungeAnimator_L()
    {
        guideAnimator.SetInteger("controll", 2);
        trAnimaotr.SetInteger("tr_controll", 2);
    }
    private void RungeAnimator_R()
    {
        guideAnimator.SetInteger("controll", 3);
        trAnimaotr.SetInteger("tr_controll", 2);
    }
    private void BridgeAnimator()
    {
        guideBotObj2.SetActive(false);
        guideAnimator.SetInteger("controll", 4);
        trAnimaotr.SetInteger("tr_controll", 3);
    }
}
