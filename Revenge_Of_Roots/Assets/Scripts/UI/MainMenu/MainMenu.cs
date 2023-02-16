using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [Header("UI Initializations")]
    [SerializeField] private string settingsMenuSceneName;
    [SerializeField] private string stageSelectSceneName;

    public void SceneLoadPlayGame()
    {
        SceneManager.LoadScene(stageSelectSceneName, LoadSceneMode.Single);
    }

    public void SceneLoadSettingsMenu()
    {
        SceneManager.LoadSceneAsync(settingsMenuSceneName, LoadSceneMode.Additive);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
