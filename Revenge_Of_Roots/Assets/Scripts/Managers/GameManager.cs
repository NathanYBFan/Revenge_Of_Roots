using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }
    // Start is called before the first frame update
    void Awake()
    {
        if (gameManager != null)
        {
            Destroy(this.gameObject);
            return;
        }
    }
}
