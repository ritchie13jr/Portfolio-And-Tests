using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject backButtonObj = GameObject.FindGameObjectWithTag("BackToMenu");

        if (backButtonObj != null)
        {
            Button button = backButtonObj.GetComponent<Button>();

            if (button != null)
            {
                button.onClick.RemoveAllListeners();
                button.onClick.AddListener(LoadMenu);
            }
        }
    }


    public void LoadSkillTree() 
    {
        SceneManager.LoadScene(NameLevels.SkillTree.ToString());
    }

    public void LoadMenu() 
    {
        SceneManager.LoadScene(NameLevels.Menu.ToString());
    }

    public void ExitGame() 
    {
        Application.Quit();
    }
}
