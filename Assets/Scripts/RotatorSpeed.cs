using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RotatorSpeed : MonoBehaviour
{

    public Slider speedSlider;
    public Text speedText;

    void Start()
    {

    }
    public void SpeedControl()
    {
        Rotator.speed = speedSlider.value;
        speedText.text = speedSlider.value.ToString();
    }

}