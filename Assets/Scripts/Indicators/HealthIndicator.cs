using TMPro;
using UnityEngine;

public abstract class HealthIndicator : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected virtual void Start()
    {
        SetMax();
        SetCurrent();
    }

    private void OnEnable()
    {
        Health.Changed += SetCurrent;
    }

    private void OnDisable()
    {
        Health.Changed -= SetCurrent;
    }

    protected virtual void SetMax() {}

    protected virtual void SetCurrent() {}
}
