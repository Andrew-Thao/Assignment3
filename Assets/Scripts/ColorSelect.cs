using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public Text ColorText;
    public Rotator rotator;


    // Start is called before the first frame update
    void Start()
    {
        rotator.GetComponent<Renderer>().material.color = Color.black;
    }

   
    public void ChooseColor() // use in the change event for the dropdown
    {
        switch (ColorDropdown.value)
        {
            case 1:
                ColorText.text = ColorDropdown.options[1].text;
                rotator.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                ColorText.text = ColorDropdown.options[2].text;
                rotator.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                ColorText.text = ColorDropdown.options[3].text;
                rotator.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            default:
                ColorText.text = ColorDropdown.options[0].text;
                rotator.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
}