using UnityEngine;
namespace ROR
{
    public class PlayerStatsTracker : MonoBehaviour
    {
        public static PlayerStatsTracker _playerStatsTracker { get; private set; }

        //public static character characterSelecter { get; private set; }

        // Number of stacks
        public static int numbOfSuns { get; private set; }
        public static int numbOfWalls { get; private set; }
        public static int numbOfMaxHp { get; private set; }
        public static int numbOfRegen { get; private set; }
        public static int numbOfMoveSpeed { get; private set; }
        public static int numbOfAttackSpeed { get; private set; }
        public static int level { get; private set; }
        void Awake()
        {
            if (_playerStatsTracker != null && _playerStatsTracker != this)
            {
                Destroy(this.gameObject);
                return;
            }
            // DontDestroyOnLoad handled by GameManagerScript;
        }

        public void GameRestart()
        {
            numbOfSuns = 0;
            numbOfWalls = 0;
            numbOfMaxHp = 0;
            numbOfRegen = 0;
            numbOfMoveSpeed = 0;
            numbOfAttackSpeed = 0;
            level = 0;
        }

        public void AddSun(int sunsToAdd) { numbOfSuns += sunsToAdd; }
        public void AddWall(int wallToAdd) { numbOfWalls += wallToAdd; }
        public void AddMaxHp(int maxHpToAdd) { numbOfMaxHp += maxHpToAdd; }
        public void AddRegen(int regenToAdd) { numbOfRegen += regenToAdd; }
        public void AddMoveSpeed(int speedToAdd) { numbOfMoveSpeed += speedToAdd; }
        public void AddAttackSpeed(int attackSpeedToAdd) { numbOfAttackSpeed += attackSpeedToAdd; }
        public void AddLevel(int levelsToAdd) { level += levelsToAdd; }

    }
}