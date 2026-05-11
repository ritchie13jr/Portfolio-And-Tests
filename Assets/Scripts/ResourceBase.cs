using System;
using UnityEngine;

public class ResourceBase
{
    float maxValue;
    float value;

    public enum ResourceType { Life, Mana, Stamina, Armor}
    public ResourceType resourceType;

    public static event Action <ResourceBase, ResourceType> OnValueChange;

    public ResourceBase(float _MaxValue, ResourceType _Type)
    {
        maxValue = _MaxValue;
        value = _MaxValue;
        resourceType = _Type;

        OnValueChange?.Invoke(this, resourceType);
    }

    public void AddValue(float _Value)
    {

        value += _Value;

        value = Mathf.Clamp(value, 0, maxValue);

        Debug.Log(value + " " +  maxValue);


        OnValueChange?.Invoke(this, resourceType);
    }

    public void ResetValue()
    {
        value = maxValue;
        OnValueChange?.Invoke(this, resourceType);
    }

    public void SetNewMaxValue(float _MaxValue, bool refill = true)
    {
        maxValue = _MaxValue;

        if (refill)
            ResetValue();

        OnValueChange?.Invoke(this, resourceType);
    }

    public float GetValue() { return value; }
    public float GetMaxValue() { return maxValue; }
}
