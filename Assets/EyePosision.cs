using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;

public class EyePosision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PointerUtils.SetGazePointerBehavior(PointerBehavior.AlwaysOn);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CoreServices.InputSystem.EyeGazeProvider.HitPosition);
    }
}
