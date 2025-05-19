using TMPro;
using UnityEngine;

public abstract class HealthIndicator : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected virtual void Awake()
    {
        SetMax();
        SetCurrent();
    }

    private void OnEnable()
    {
        Health.OnHealthChange += SetCurrent;
    }

    private void OnDisable()
    {
        Health.OnHealthChange -= SetCurrent;
    }

    protected virtual void SetMax() {}

    protected virtual void SetCurrent() {}
}
