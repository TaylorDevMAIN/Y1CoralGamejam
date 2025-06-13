using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataSave : MonoBehaviour
{
    public float key1 = 0;

    void Start()
    {
        key1 = PlayerPrefs.GetFloat("key1");
    }

    void Update()
    {
       PlayerPrefs.SetFloat("key1", key1);
    }
}
