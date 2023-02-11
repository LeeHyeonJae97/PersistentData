using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Settings _settings;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            _settings.Load();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _settings.Save();
        }
    }
}
