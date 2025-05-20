using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonListener : MonoBehaviour
{
    [SerializeField] protected float Value;
    [SerializeField] protected Health Health;

    protected Button Button;

    protected virtual void Awake()
    {
        Button = GetComponent<Button>();
    }
}
