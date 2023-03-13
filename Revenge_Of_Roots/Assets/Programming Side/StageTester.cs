using UnityEngine;
using UnityEngine.SceneManagement;

namespace ROR.Player
{
    public class StageTester : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;
        [SerializeField] private BaseCharacter baseCharacter;

        // Start is called before the first frame update
        void Start()
        {
            if (gameManager.getCharacterSelected() == null)
                gameManager.SelectedCharacter = baseCharacter;
            if (gameManager.getLevelSelected().CompareTo("") == 0)
                gameManager.newLevelSelected(SceneManager.GetActiveScene().name);
        }
    }
}
