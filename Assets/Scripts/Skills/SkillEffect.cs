using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "SkillEffect", menuName = "Scriptable Objects/SkillEffect")]
public class SkillEffect : ScriptableObject
{
    public enum EffectType { AddLife, AddMana, AddArmor}
    public EffectType effect;

    public float amount = 5.0f;

    public void ActivateEffect() 
    {
        switch (effect) 
        {
            case EffectType.AddLife:
                PlayerResources.Instance.SetMaxLife
                    (PlayerResources.Instance.lifeResource.GetMaxValue() + amount);
                break;

            case EffectType.AddMana:
                PlayerResources.Instance.SetMaxMana
                    (PlayerResources.Instance.manaResource.GetMaxValue() + amount, true);

                break;

            case EffectType.AddArmor:
                PlayerResources.Instance.AddArmor(amount);
                break;
        }
    }
}
