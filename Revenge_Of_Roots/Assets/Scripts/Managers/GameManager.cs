using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _gameManager { get; private set; }

    // Start is called before the first frame update
    void Awake()
    {
        if (_gameManager != null && _gameManager != this)
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
        _gameManager = this;
    }
}
