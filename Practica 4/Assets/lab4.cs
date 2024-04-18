using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class lab4 : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        //texto con gradiente
        Label text = root.Q<Label>("text");

        text.text = @"<b><gradient=""grad_lab4""> texto con gradienteeeeeee </gradient></b>";
    }
}
