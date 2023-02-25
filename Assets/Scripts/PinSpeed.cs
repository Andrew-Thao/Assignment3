using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PinSpeed : MonoBehaviour
{

    public Slider speedSlider;
    public Text speedText;
    
    void Start()
    {

    }
    public void SpeedControl()
    {
        Pin.speed = speedSlider.value;
        speedText.text = speedSlider.value.ToString();
    }

}