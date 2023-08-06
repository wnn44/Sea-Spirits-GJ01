using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyManager : MonoBehaviour
{

    public int NumberOfKeys;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private int _totalKeys;

    private void Start()
    {
        //NumberOfKeys = Progress.Instance.Keys;
        _text.text = NumberOfKeys.ToString() + " из "+ _totalKeys.ToString();
    }

    public void AddOne()
    {
        NumberOfKeys += 1;
        _text.text = NumberOfKeys.ToString() + " из " + _totalKeys.ToString();

    }

    public void SaveToProgress()
    {
        //Progress.Instance.Keys = NumberOfKeys;
    }

    public void SpendMoney(int volue)
    {
        NumberOfKeys -= volue;
        _text.text = NumberOfKeys.ToString();
    }
}
