using System.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class SmoothHealthBar : HealthBar
{
    protected override void SetCurrent()
    {
        StartCoroutine(ChangingBar(Health.Value / Health.MaxValue));
    }

    private IEnumerator ChangingBar(float value)
    {
        float delta = 0.005f;

        while (Mathf.Approximately(Slider.value, value) == false)
        {
            Slider.value = Mathf.MoveTowards(Slider.value, value, delta);
            yield return null;
        }
    }
}
