using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
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
