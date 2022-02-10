using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeGaletSize : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject Galet;


    Slider SliderScaleX;
    Slider SliderScaleY;
    Slider SliderScaleZ;


    void Start()
    {
        SliderScaleX = GameObject.Find("SliderScaleX").GetComponent<Slider>();
        SliderScaleY = GameObject.Find("SliderScaleY").GetComponent<Slider>();
        SliderScaleZ = GameObject.Find("SliderScaleZ").GetComponent<Slider>();

        SliderScaleX.minValue = 0.1f;
        SliderScaleY.minValue = 0.1f;
        SliderScaleZ.minValue = 0.1f;


        SliderScaleX.onValueChanged.AddListener(resizeGalet);
        SliderScaleY.onValueChanged.AddListener(resizeGalet);
        SliderScaleZ.onValueChanged.AddListener(resizeGalet);
    }

    private void resizeGalet(float arg0)
    {
        float x = SliderScaleX.value * 10f;
        float y = SliderScaleY.value * 10f;
        float z = SliderScaleZ.value * 10f;

        Galet.transform.localScale = new Vector3(x, y, z);
    }

}
