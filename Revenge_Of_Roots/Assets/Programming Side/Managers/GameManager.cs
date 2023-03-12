using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
namespace ROR.Player
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager _gameManager { get; private set; }
        [SerializeField] public List<GameObject> players;
        [SerializeField, ReadOnly] private string levelSelected;
        [SerializeField, ReadOnly] private BaseCharacter selectedCharacter = null; 
        public BaseCharacter SelectedCharacter
        {
            get => selectedCharacter;
            set { SelectedCharacter = value; }
        }
        
        private enum GAME_STATE 
        { 
            FreshLoad,
            SaveLoad,
            Play,
            Pause,
            Dead,

        }

        // Start is called before the first frame update
        void Awake()
        {
            if (_gameManager != null && _gameManager != this)
            {
                Destroy(this.gameObject);
                return;
            }

            DontDestroyOnLoad(this.gameObject);
            _gameManager = this;
        }

        public void newLevelSelected (string selectedScene) { levelSelected = selectedScene; }
        public void newCharacterSelected (BaseCharacter character) { selectedCharacter = character; }
        public string getLevelSelected () { return levelSelected; }
    }
}