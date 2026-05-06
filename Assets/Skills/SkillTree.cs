using UnityEngine;
using System.Collections.Generic;

public class SkillTree : MonoBehaviour
{
    public int skillPoints = 0;

    public List<Skill> skills;

    void Start()
    {
        CheckUnlock();
    }

    public void CheckUnlock() 
    {
        foreach (Skill skill in skills)
        {
            skill.CheckUnlock();
        }
    }
}
