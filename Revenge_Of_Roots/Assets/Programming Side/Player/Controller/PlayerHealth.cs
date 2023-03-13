using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

namespace ROR.Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField, ReadOnly] private int maxPlayerHealthPoints = 100;
        [SerializeField, ReadOnly] private int currentPlayerHealthPoints;

        public void ResetPlayerHP() { currentPlayerHealthPoints = maxPlayerHealthPoints; }
        public void SetPlayerMaxHP(int newHP) { maxPlayerHealthPoints = newHP; }
        public int GetPlayerMaxHP() { return maxPlayerHealthPoints; }
    }
}
