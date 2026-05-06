using UnityEngine;

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
                GameManager.m_Instance.m_Player.GetComponent<Combat>().AddMaxLife(amount);
                break;

            case EffectType.AddMana:
                GameManager.m_Instance.m_Player.GetComponent<Combat>().AddMaxMana(amount, false);
                break;

            case EffectType.AddArmor:
                Debug.Log("ArmorAdded");
                break;
        }
    }
}
