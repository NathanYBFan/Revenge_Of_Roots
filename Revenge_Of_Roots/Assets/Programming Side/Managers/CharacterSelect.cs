using UnityEngine;
using UnityEngine.SceneManagement;

namespace ROR.Player {
public class CharacterSelect : MonoBehaviour
{
        [SerializeField] private string nameOfCurrentScene;
        [SerializeField] private SelectButtonManager selectButtonManager;

        public void Awake() {
            selectButtonManager.disableAllOutlines();
            if (GameManager._gameManager.getCharacterSelected() != null)
                selectButtonManager.EnableConfirmButton();
            else 
                selectButtonManager.DisableConfirmButton();    
        }

        public void SingleGameSceneLoad() {
            SceneManager.LoadScene(GameManager._gameManager.getLevelSelected(), LoadSceneMode.Single);
        }

        public void CharacterButtonPressed(BaseCharacter character) {
            GameManager._gameManager.newCharacterSelected(character);
            selectButtonManager.enableOutline(character.characterID);
            selectButtonManager.EnableConfirmButton();
        }

        public void BackButtonPressed(string prevScene) {
            SceneManager.LoadScene(prevScene, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(nameOfCurrentScene);
        }

    }
}