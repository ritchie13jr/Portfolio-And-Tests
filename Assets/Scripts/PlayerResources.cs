using System;
using UnityEngine;

public class PlayerResources : MonoBehaviour
{
    public ResourceBase lifeResource;
    public ResourceBase manaResource;
    public float armor;

    public float initialMaxLife;
    public float initialMaxMana;
    public int initialArmor;

    public static PlayerResources Instance;

    public static Action<float> OnArmorChanged;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else 
        {
            Instance = this;
            lifeResource = new ResourceBase(initialMaxLife, ResourceBase.ResourceType.Life);
            manaResource = new ResourceBase(initialMaxMana, ResourceBase.ResourceType.Mana);
            armor = initialArmor;
            OnArmorChanged?.Invoke(armor);
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddLife(float amount) 
    {
        lifeResource.AddValue(amount);
    }

    public void SetMaxLife(float amount) 
    {
        lifeResource.SetNewMaxValue(amount, true);
    }

    public void AddMana(float amount) 
    {
        manaResource.AddValue(amount);
    }

    public void SetMaxMana(float amount, bool refill) 
    {
        manaResource.SetNewMaxValue(amount, refill);
    }

    public void AddArmor(float amount) 
    {
        armor += amount;
        OnArmorChanged?.Invoke(amount);
    }
}
