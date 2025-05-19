using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : HealthIndicator
{
    protected Slider Slider;

    protected override void Start()
    {
        Slider = GetComponent<Slider>();
        Slider.maxValue = 1;
        Slider.minValue = 0;
    }

    protected override void SetCurrent()
    {
        Slider.value = Health.Value / Health.MaxValue;
    }
}
