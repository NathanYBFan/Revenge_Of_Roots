using UnityEngine;
using UnityEngine.SceneManagement;

namespace ROR.Player {
public class CharacterSelect : MonoBehaviour
{
        [SerializeField] private string nameOfCurrentScene;
        [SerializeField] private SelectButtonManager selectButtonManager;
        public void SingleGameSceneLoad() {
            SceneManager.LoadScene(GameManager._gameManager.getLevelSelected(), LoadSceneMode.Single);
        }

        public void AdditiveSceneLoad(string sceneToLoad) {
            BackButtonPressed();
            SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Additive);
        }

        public void CharacterButtonPressed(BaseCharacter character) {
            GameManager._gameManager.newCharacterSelected(character);
            selectButtonManager.enableOutline(character.characterID);
            selectButtonManager.EnableConfirmButton();
        }

        public void BackButtonPressed() {
            SceneManager.UnloadSceneAsync(nameOfCurrentScene);
        }

    }
}