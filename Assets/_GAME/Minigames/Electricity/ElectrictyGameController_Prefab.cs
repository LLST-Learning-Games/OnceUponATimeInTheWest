using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectrictyGameController_Prefab : MonoBehaviour
{
    [SerializeField] private SpinDial _dial;
    [SerializeField] private LightArray _lights;

    [SerializeField] private Button _chargeButton;

    // Start is called before the first frame update
    void Start()
    {
        _dial.OnDialSpinComplete += OnDialSpinComplete;
        _lights.OnAllLightsLit += OnAllLightsLit;
    }

    private void OnDialSpinComplete()
    {
        _lights.TurnOnNextLight();
    }

    private void OnAllLightsLit()
    {
        _chargeButton.interactable = true;
    }

    public void OnChargeButtonPressed()
    {
        Destroy(gameObject);
    }
    

}
