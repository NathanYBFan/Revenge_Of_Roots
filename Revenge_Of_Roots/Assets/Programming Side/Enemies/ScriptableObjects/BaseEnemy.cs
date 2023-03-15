using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ROR
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "ROR/Enemy", order = 0)]
    public class BaseEnemy : ScriptableObject
    {
        [SerializeField] public int enemyID = 0;
        [SerializeField] private string enemyName = "EnemyName_Ability_IDNumber";
        [SerializeField] private Sprite enemySprite;
        [SerializeField] private float moveSpeed = 5;
        [SerializeField] private int enemyHP = 100;
        [SerializeField] private GameObject weaponPrefab;
        [SerializeField] private RuntimeAnimatorController enemyAnimator;
        public int EnemyID => enemyID;
        public string EnemyName => enemyName;
        public Sprite EnemySprite => enemySprite;
        public float MoveSpeed => moveSpeed;
        public int EnemyHP => enemyHP;
        public GameObject WeaponPrefab => weaponPrefab;
        public RuntimeAnimatorController EnemyAnimator => enemyAnimator;
    }
}
