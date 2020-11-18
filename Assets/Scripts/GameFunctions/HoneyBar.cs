using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HoneyBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHoney(int MaxHoney)
    {
        slider.maxValue = MaxHoney;
    }
    public void SetHoney(int Honey)
    {
        slider.value = Honey;
    }
}
