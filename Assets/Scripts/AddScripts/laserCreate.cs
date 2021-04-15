using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserCreate : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;
    private Transform mainCharTrans;

    public GameObject prefabs;
    private GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        device = SteamVR_Controller.Input(5);
    }

    // Update is called once per frame
    void Update()
    {
        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            //Debug.Log("당김");
            laser = Instantiate(prefabs, transform.position, transform.rotation);
            laser.transform.parent = gameObject.transform;
        }
    }
}
