using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health;

    public event Action Changed;

    public float MaxValue => _health;
    public float Value { get; private set; }

    private void Awake()
    {
        Value = MaxValue;
    }

    public void Reduce(float health)
    {
        if (health < 0)
            return;

        Value -= health;

        if (Value < 0)
           Value = 0;

        Changed?.Invoke();
    }

    public void Add(float health)
    {
        if (health < 0)
            return;

        Value += health;

        if (Value > MaxValue)
            Value = MaxValue;

        Changed?.Invoke();
    }
}