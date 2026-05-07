using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Skill : MonoBehaviour
{
    public SkillNode skillNode;
    public List<Skill> prevSkills;

    private SkillTree skillTree;
    private bool completed;
    private int currentUses;
    private Button button;

    public void Awake()
    {
        button = GetComponent<Button>();
        skillTree = GetComponentInParent<SkillTree>();
        completed = false;

        CheckUnlock();
    }

    public void CheckUnlock()
    {
        if (completed)
        {
            button.interactable = false;
            return;
        }

        bool allPrevCompleted = true;

        foreach (Skill prevSkill in prevSkills)
        {
            if (!prevSkill.completed)
            {
                allPrevCompleted = false;
                break;
            }
        }

        button.interactable = allPrevCompleted;
    }

    public void Clicked() 
    {
        if (skillNode.TryUnlockSkill(skillTree.skillPoints))
        { 
            skillTree.skillPoints -= skillNode.cost;
            currentUses += 1;

            if (currentUses >= skillNode.maxUses) 
            {
                button.interactable = false;
                completed = true;
            }
            skillTree.CheckUnlock();
        }
    }
}
