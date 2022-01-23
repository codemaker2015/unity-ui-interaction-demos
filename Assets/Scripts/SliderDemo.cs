using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderDemo : MonoBehaviour
{
    [SerializeField]
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initial slider value: " + slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged() {
        Debug.Log("Slider value: " + slider.value);
    }
}
