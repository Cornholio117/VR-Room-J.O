using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocomotionSettingsChecker : MonoBehaviour
{
    public Toggle Snap;
    public Toggle Continus;

    private void Update()
    {
        if(Snap.isOn == true)
        {
            Continus.isOn = false;
        }
        else
        {
            Snap.isOn = false;
            Continus.isOn = true;
        }
    }
}
