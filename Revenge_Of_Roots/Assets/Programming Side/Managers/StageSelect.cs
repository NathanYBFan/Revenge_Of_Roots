using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using NaughtyAttributes;

namespace ROR.Player
{
    public class StageSelect : MonoBehaviour
    {
        [SerializeField] private string levelSelectMenuSceneName;
        [SerializeField, Required] private SelectButtonManager selectButtonManager;
        public void Start() {
            selectButtonManager.disableAllOutlines();
            if (!(GameManager._gameManager.getLevelSelected().CompareTo("") == 0)) {
                selectButtonManager.EnableConfirmButton();
                selectButtonManager.enableOutline(int.Parse(GameManager._gameManager.getLevelSelected().Substring(GameManager._gameManager.getLevelSelected().Length - 2)) - 1);
            }
            else 
                selectButtonManager.DisableConfirmButton();
            
        }
        public void SingleLevelLoader(string levelToLoad) {
            SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
        }

        public void AdditiveLevelLoader(string levelToLoad) {
            BackButtonPressed();
            SceneManager.LoadScene(levelToLoad, LoadSceneMode.Additive);
        }

        public void BackButtonPressed() {
            SceneManager.UnloadSceneAsync(levelSelectMenuSceneName);
        }

        public void LevelButtonSelected(string levelSelected) {
            GameManager._gameManager.newLevelSelected(levelSelected);
            selectButtonManager.enableOutline(int.Parse(levelSelected.Substring(levelSelected.Length - 2)) - 1);
            selectButtonManager.EnableConfirmButton();
        }
    }
}