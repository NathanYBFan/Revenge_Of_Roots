using UnityEngine;
using NaughtyAttributes;

namespace ROR.Entity
{
    public class EntityHealth : MonoBehaviour
    {
        [SerializeField, ReadOnly] private int maxPlayerHealthPoints = 100;
        [SerializeField, ReadOnly] private int currentPlayerHealthPoints;
        [SerializeField] private DamageNumberInstantiator damageNumber;

        void Start() {
            ResetPlayerHP();
        }

        public void ResetPlayerHP() { currentPlayerHealthPoints = maxPlayerHealthPoints; }
        public void SetPlayerMaxHP(int newHP) { maxPlayerHealthPoints = newHP; }
        public int GetPlayerMaxHP() { return maxPlayerHealthPoints; }
        public int GetPlayerCurrentHP() { return currentPlayerHealthPoints; }
        public void DamageEntityCurrentHp(int damage) {
            currentPlayerHealthPoints -= damage;
            damageNumber.SetupDamageNumber(damage, this.gameObject.transform.position);
            CheckIsDead();
        }
        public void HealEntityPlayerCurrentHp(int healing) {
            currentPlayerHealthPoints += healing;
            damageNumber.SetupHealingNumber(healing, this.gameObject.transform.position);
        }

        private void CheckIsDead() {
            if (currentPlayerHealthPoints <= 0) {
                // If player dies
                Time.timeScale = 0;
            }
        }
    }
}
