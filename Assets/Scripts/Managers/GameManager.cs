using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerController playerController;

    void Awake()
    {
        if (Instance != null) 
        {
            Destroy(this);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
