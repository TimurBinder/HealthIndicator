using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class HealingButton : ButtonListener
{
    protected override void Awake()
    {
        base.Awake();
        Button.onClick.AddListener(AddHealth);
    }

    private void AddHealth()
    {
        Health.Add(Value);
    }
}
