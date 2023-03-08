using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ROR.Player
{
    public class StageSelect : MonoBehaviour
    {
        [SerializeField] private Outline[] buttonOutlineToggles;
        [SerializeField] private string levelSelectMenuSceneName;
        public void Awake() { disableAllOutlines(); }
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

        public void disableAllOutlines() {
            foreach (Outline o in buttonOutlineToggles)
                o.enabled = false;
        }

        // 0 Baseds
        public void enableOutline(int buttonOutlineToToggle) {
            disableAllOutlines();
            buttonOutlineToggles[buttonOutlineToToggle].enabled = true;
        }
        public void LevelButtonSelected(string levelSelected) {
            GameManager._gameManager.newLevelSelected(levelSelected);
            enableOutline(int.Parse(levelSelected.Substring(levelSelected.Length - 2)) - 1);
        }
    }
}