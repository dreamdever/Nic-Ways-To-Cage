using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour {
    public Slider slider = null;

    public void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        slider = gameObject.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        Debug.Log(slider.value);
        AudioListener.volume = slider.value;
    }
}
