using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChkColor : MonoBehaviour
{
    public GameObject sphere1, sphere2, sphere3;
    private Color color1, color2, color3;

    // Start is called before the first frame update
    void Start()
    {
        color1 = sphere1.GetComponent<MeshRenderer>().material.color;
        color2 = sphere2.GetComponent<MeshRenderer>().material.color;
        color3 = sphere3.GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(color1 == Color.green && color2 == Color.green && color3 == Color.green)
        {
            CntNum.chkCollTime = false;
        }
    }
}