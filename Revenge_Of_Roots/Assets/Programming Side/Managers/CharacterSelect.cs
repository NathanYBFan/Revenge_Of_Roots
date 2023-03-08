using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] private string nameOfCurrentScene;

    public void SingleSceneLoad(string sceneToLoad) {
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
    }

    public void AdditiveSceneLoad(string sceneToLoad) {
        BackButtonPressed();
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Additive);
    }

    public void BackButtonPressed() {
        SceneManager.UnloadSceneAsync(nameOfCurrentScene);
    }

}
