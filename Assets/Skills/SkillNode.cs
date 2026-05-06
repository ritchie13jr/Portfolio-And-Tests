using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SkillNode", menuName = "Scriptable Objects/SkillNode")]
public class SkillNode : ScriptableObject
{
    public int maxUses;
    public int cost;
    public SkillEffect effect;

    public bool TryUnlockSkill(int skillPoints) 
    {
        if (skillPoints >= cost)
        {
            effect.ActivateEffect();
            return true;
        }
        return false;
    }
}
