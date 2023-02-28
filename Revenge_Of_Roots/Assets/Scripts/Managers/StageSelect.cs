using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    [SerializeField] private string levelSelectMenuSceneName;
    public void LoadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
    }

    public void BackButton()
    {
        SceneManager.UnloadSceneAsync(levelSelectMenuSceneName);
    }
}
