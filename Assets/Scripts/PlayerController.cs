using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject pauseMenuPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (pauseMenuPanel != null) 
            {
                pauseMenuPanel.SetActive(!pauseMenuPanel.activeSelf);
            }
        }

        if (Input.GetKeyDown(KeyCode.F)) 
        {
            PlayerResources.Instance.AddLife(-1);
        }
    }
}
