using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Text healthTxt;
    private Image healthImg;
    void Start()
    {
        healthTxt = GetComponentInChildren<Text>();
        healthImg = transform.GetChild(0).GetComponent<Image>();
    }
    public void SetHealthBar(int _value)
    {
        if (_value <= 0)
            _value = 0;
        healthImg.fillAmount = _value * 0.01f;
        healthTxt.text = _value + "%";
    }
}
