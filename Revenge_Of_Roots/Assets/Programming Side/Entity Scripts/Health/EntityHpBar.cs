using UnityEngine;
using UnityEngine.UI;

namespace ROR.Entity
{
    public class EntityHpBar : MonoBehaviour
    {
        [SerializeField] private EntityHealth playerHealth;
        [SerializeField] private Slider slider;
        
        public void UpdateUI() {
            float hpValue = (float) playerHealth.GetEntityCurrentHP() / (float) playerHealth.GetEntityMaxHP();
            slider.value = hpValue;
        }
    }
}