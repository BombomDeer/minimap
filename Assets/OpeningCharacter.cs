using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCharacter : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveTo(gameObject,
            iTween.Hash("path", iTweenPath.GetPath("CamPath"),
                        "time", 20.0f,
                        "easetype", iTween.EaseType.linear,
                        "looktarget", target.transform,
                        "delay", 0.1f));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
