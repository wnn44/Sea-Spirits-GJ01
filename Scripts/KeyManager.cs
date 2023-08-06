using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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
            OpenDoor();


    }

    public void SaveToProgress()
    {
        //Progress.Instance.Keys = NumberOfKeys;
    }

    public void OpenDoor()
    {
        if (_totalKeys == keysTaken)
            GameObject.Find("ExitDoor").GetComponent<OpenDoor>().Open = true;
    }

    public void SpendKey(int volue)
    {
        keysTaken -= volue;
        _text.text = keysTaken.ToString();
    }
}
