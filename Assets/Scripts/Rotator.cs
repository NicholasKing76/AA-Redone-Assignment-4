using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public float speed = 100;
    public Slider MySlider;

    void Update()
    {
        
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
        speed = MySlider.value;
    }
}
