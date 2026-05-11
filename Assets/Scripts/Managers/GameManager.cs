using UnityEngine;
using System;

public enum NameLevels{ Menu, SkillTree}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public PlayerController playerController;
    public LevelManager levelManager;

    void Awake()
    {
        if (Instance != null) 
        {
            Destroy(this);
        }

        Instance = this;
        levelManager = GetComponent<LevelManager>();
        DontDestroyOnLoad(gameObject);
    }
}
