using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialButton : MonoBehaviour
{
    CustomEditor _customEditor;

    [SerializeField] Material _material;
    [SerializeField] Button _button;
    [SerializeField] Text _text;

    public Material material
    {
        get { return _material; }
        private set { material = _material; }
    }

    public void Init(Material newMaterial, CustomEditor newCustomEditor)
    {
        _material = newMaterial;
        _customEditor = newCustomEditor;

        _button.onClick.AddListener(TaskOnClick);

        _text.text = newMaterial.name;
        Debug.Log(newMaterial.name);

    }

    void TaskOnClick()
    {
        Debug.Log("I got clicked!");

        _customEditor.SetActiveMaterial(_material);
    }
}
