using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Slider lifeBar;
    public TextMeshProUGUI lifeTMP;
    public TextMeshProUGUI manaTMP;
    public Slider manaBar;

    public TextMeshProUGUI armorTMP;

    private void OnEnable()
    {
        ResourceBase.OnValueChange += CheckValue;
        PlayerResources.OnArmorChanged += ChangeArmor;
    }

    private void OnDisable()
    {
        ResourceBase.OnValueChange -= CheckValue;
        PlayerResources.OnArmorChanged -= ChangeArmor;
    }

    void CheckValue(ResourceBase resource, ResourceBase.ResourceType type) 
    {
        if (type == ResourceBase.ResourceType.Life) 
        {
            ChangeLife(resource.GetMaxValue(), resource.GetValue());
        } 

        if (type == ResourceBase.ResourceType.Mana) 
        {
            ChangeMana(resource.GetMaxValue(), resource.GetValue());
        } 
    }

    void ChangeLife(float maxValue, float value) 
    {
        float pct = Mathf.Clamp01(value / maxValue);
        lifeTMP.text = value.ToString() + "/" + maxValue.ToString();

        lifeBar.value = pct;
    }

    void ChangeMana(float maxValue, float value) 
    {
        float pct = Mathf.Clamp01(value / maxValue);
        manaTMP.text = value.ToString() + "/" + maxValue.ToString();

        manaBar.value = pct;
    }

    void ChangeArmor(float amount) 
    {
        armorTMP.text = amount.ToString();  
    }
}
