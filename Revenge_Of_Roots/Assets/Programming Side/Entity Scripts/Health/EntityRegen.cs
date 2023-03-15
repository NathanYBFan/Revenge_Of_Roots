using UnityEngine;
using NaughtyAttributes;

namespace ROR.Entity
{
    public class EntityRegen : MonoBehaviour
    {
        [SerializeField] private EntityHealth entityHealth;
        [SerializeField] private int regenAmount;
        [SerializeField] private float regenWaitSeconds;
        [SerializeField, ReadOnly] private float currentCounter;

        void Start() { currentCounter = regenWaitSeconds; }

        void Update() {
            currentCounter -= Time.deltaTime;
            if (currentCounter <= 0) {
                entityHealth.HealEntityCurrentHp(regenAmount);
                ResetCounter();
            }
        }
        public void ResetCounter() { currentCounter = regenWaitSeconds; }
        public void SetRegenWaitTime(float newRegenTime) { regenWaitSeconds = newRegenTime; }
        public float GetRegenWaitTime() { return regenWaitSeconds; }
        public void SetRegenAmount(int newRegenAmount) { regenAmount = newRegenAmount; }
        public int GetRegenAmount() { return regenAmount; }
    }
}