using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenuLogic : MonoBehaviour
{
    public void SaveSettingsChange()
    {
        Debug.Log("Save new settings");
    }

    public void CancelSettingsChange()
    {
        Debug.Log("No changes made");
    }
}
