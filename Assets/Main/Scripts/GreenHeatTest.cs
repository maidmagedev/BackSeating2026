using System;
using System.Collections;
using Newtonsoft.Json.Linq;
using UnityEngine;

public class GreenHeatTest : MonoBehaviour
{
    public GreenHeatEventManager greenHeatEventManager;

    void Awake()
    {
        GreenHeatEventManager.OnGreenHeatClick += OnClick;
    }

    private void OnClick(GreenHeatMessage message)
    {
        Debug.Log(message.Print());
    }
}
