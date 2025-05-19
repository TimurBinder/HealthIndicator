using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health;

    public event Action OnHealthChange;

    public float MaxValue => _health;
    public float Value { get; private set; }
    public bool IsAlive => Value > 0;

    protected virtual void Awake()
    {
        Value = MaxValue;
    }

    public void Reduce(float health)
    {
        Value -= health;
        OnHealthChange?.Invoke();

        if (IsAlive == false)
            Destroy(gameObject);
    }

    public void Add(float health)
    {
        Value += health;

        if (Value > MaxValue)
            Value = MaxValue;

        OnHealthChange?.Invoke();
    }
}