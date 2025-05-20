using UnityEngine.UI;

public class DamagingButton : ButtonListener
{
    protected override void Awake()
    {
        base.Awake();
        Button.onClick.AddListener(ReduceHealth);
    }

    private void ReduceHealth()
    {
        Health.Reduce(Value);
    }
}
