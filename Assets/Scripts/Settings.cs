using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "ScriptableObject/Settings")]
public class Settings : PlayerPrefsData
{
    private const string KEY = "settings";

    [SerializeField] private int _version;
    [SerializeField] private bool _development;

    public override void Load()
    {
        if (!PlayerPrefs.HasKey(KEY)) return;

        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(KEY), this);
    }

    public override void Save()
    {
        PlayerPrefs.SetString(KEY, JsonUtility.ToJson(this));
    }
}
