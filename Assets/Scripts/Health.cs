using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health;

    public event Action HealthChanged;

    public float MaxValue => _health;
    public float Value { get; private set; }

    private void Awake()
    {
        Value = MaxValue;
    }

    public void Reduce(float health)
    {
        Value -= health;

        if (Value < 0)
           Value = 0;

        HealthChanged?.Invoke();
    }

    public void Add(float health)
    {
        Value += health;

        if (Value > MaxValue)
            Value = MaxValue;

        HealthChanged?.Invoke();
    }
}