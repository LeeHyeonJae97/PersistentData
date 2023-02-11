using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerPrefsData : ScriptableObject, IPersistentData
{
    public abstract void Load();
    public abstract void Save();
}
