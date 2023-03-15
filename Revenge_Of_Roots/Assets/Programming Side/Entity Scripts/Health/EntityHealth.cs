using UnityEngine;
using NaughtyAttributes;

namespace ROR.Entity
{
    public class EntityHealth : MonoBehaviour
    {
        [SerializeField, ReadOnly] private int maxEntityHealthPoints = 100;
        [SerializeField, ReadOnly] private int currentEntityHealthPoints;
        [SerializeField] private EntityRegen entityRegen;
        [SerializeField] private DamageNumberInstantiator damageNumber;
        [SerializeField] private EntityHpBar healthBar;

        void Start() {
            ResetEntityHP();
        }

        public void ResetEntityHP() { currentEntityHealthPoints = maxEntityHealthPoints; }
        public void SetEntityMaxHP(int newHP) { maxEntityHealthPoints = newHP; }
        public int GetEntityMaxHP() { return maxEntityHealthPoints; }
        public int GetEntityCurrentHP() { return currentEntityHealthPoints; }
        public void DamageEntityCurrentHp(int damage) {
            currentEntityHealthPoints -= damage;
            damageNumber.SetupDamageNumber(damage, this.gameObject.transform.position);
            if (entityRegen != null)
                entityRegen.ResetCounter();
            if (healthBar != null)
                healthBar.UpdateUI();
            CheckIsDead();
        }
        public void HealEntityCurrentHp(int healing) {
            if ((currentEntityHealthPoints + healing) > maxEntityHealthPoints)
                currentEntityHealthPoints = maxEntityHealthPoints;
            else
                currentEntityHealthPoints += healing;
            healthBar.UpdateUI();
            damageNumber.SetupHealingNumber(healing, this.gameObject.transform.position);
        }
        private void CheckIsDead() {
            if (currentEntityHealthPoints <= 0) {
                // If player dies
                Time.timeScale = 0;
            }
        }
    }
}
