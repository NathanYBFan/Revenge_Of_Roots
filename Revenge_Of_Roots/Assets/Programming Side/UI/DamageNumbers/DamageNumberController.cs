using UnityEngine;
using System.Collections;

namespace ROR
{
    public class DamageNumberController : MonoBehaviour
    {
        [SerializeField] private float textDespawnTime = 1;
        [SerializeField] private int min;
        [SerializeField] private int max;
        private float xSpeed;
        private float ySpeed;

        void Awake() {
            xSpeed = Random.Range(min, max);
            ySpeed = Random.Range(min, max);
            Buffer();
        }
        private void Buffer() {
            StartCoroutine(InitializeText());
        }

        void Update () {
            transform.position += new Vector3(xSpeed, ySpeed, 0f) * Time.deltaTime;
        }
        private IEnumerator InitializeText() {
            
            yield return new WaitForSeconds(textDespawnTime);
            Destroy(this.gameObject);
        }
    }
}