using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : HealthIndicator
{
    [SerializeField] private bool _isSmooth;

    private Slider _slider;

    protected override void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = 1;
        _slider.minValue = 0;
    }

    protected override void SetCurrent()
    {
        float newValue = Health.Value / Health.MaxValue;

        if (_isSmooth)
            StartCoroutine(ChangingBar(newValue));
        else
            _slider.value = newValue;
    }

    private IEnumerator ChangingBar(float value)
    {
        float delta = 0.005f;

        while (_slider.value != value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, value, delta);
            yield return null;
        }
    }
}
