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
                GameManager.Instance.playerController.GetComponent<Combat>().AddMaxLife(amount);
                break;

            case EffectType.AddMana:
                GameManager.Instance.playerController.GetComponent<Combat>().AddMaxMana(amount, false);
                break;

            case EffectType.AddArmor:
                Debug.Log("ArmorAdded");
                break;
        }
    }
}
