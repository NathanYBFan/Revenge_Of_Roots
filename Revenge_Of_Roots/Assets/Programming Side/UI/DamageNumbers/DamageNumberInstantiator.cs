using UnityEngine;
using TMPro;
using NaughtyAttributes;

namespace ROR
{
    public class DamageNumberInstantiator : MonoBehaviour
    {
        [SerializeField, Required] private GameObject damageNumberPrefab;

        public void SetupDamageNumber(int damageTaken, Vector3 spawnPoint) {
            damageNumberPrefab.GetComponent<TextMeshPro>().text = damageTaken.ToString();
            if (damageTaken == 0) // No damage = white
                damageNumberPrefab.GetComponent<TextMeshPro>().color = new Color(255, 255, 255);
            else if (damageTaken > 0 && damageTaken <= 20) // Small amount of damage - Yellow
                damageNumberPrefab.GetComponent<TextMeshPro>().color = new Color(200, 255, 0);
            else if (damageTaken > 20 && damageTaken <= 40) // Medium amount of damage - Bright orange
                damageNumberPrefab.GetComponent<TextMeshPro>().color = new Color(255, 200, 0);
            else if (damageTaken > 40 && damageTaken <= 60) // Big amount of damage - Orange
                damageNumberPrefab.GetComponent<TextMeshPro>().color = new Color(200, 125, 0);
            else if (damageTaken > 60 && damageTaken <= 70) // Large amount of damage - Bright orange
                damageNumberPrefab.GetComponent<TextMeshPro>().color = new Color(200, 50, 0);
            else // Max damage - Red
                damageNumberPrefab.GetComponent<TextMeshPro>().color = new Color(255, 0, 0);

            Instantiate(damageNumberPrefab, spawnPoint, Quaternion.identity);
        }

        public void SetupHealingNumber(int healingRecieved, Vector3 spawnPoint) {
            damageNumberPrefab.GetComponent<TextMeshPro>().color = new Color(0, 255, 0);
            damageNumberPrefab.GetComponent<TextMeshPro>().text = healingRecieved.ToString();
            Instantiate(damageNumberPrefab, spawnPoint, Quaternion.identity);
        }
    }
}
