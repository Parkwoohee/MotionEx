using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasteSacle : MonoBehaviour
{
    IKModelState initModelState;
    private GameObject currentCharacter;

    // Start is called before the first frame update
    void Start()
    {
        currentCharacter = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        currentCharacter.transform.localScale = initModelState.modelScale; //캐릭터 scale
    }
}
