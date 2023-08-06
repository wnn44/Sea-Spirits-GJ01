using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyManager : MonoBehaviour
{

    public int keysTaken;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private int _totalKeys;

    private void Start()
    {
        //NumberOfKeys = Progress.Instance.Keys;
        _text.text = keysTaken.ToString() + " из "+ _totalKeys.ToString();
    }

    public void AddOne()
    {
            keysTaken += 1;
            _text.text = keysTaken.ToString() + " из " + _totalKeys.ToString();
    }

    public void SaveToProgress()
    {
        //Progress.Instance.Keys = NumberOfKeys;
    }

    public void SpendKey(int volue)
    {
        keysTaken -= volue;
        _text.text = keysTaken.ToString();
    }
}
