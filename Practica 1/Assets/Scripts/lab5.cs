using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class lab5 : MonoBehaviour
{
    VisualElement plantilla;

    TextField input_nombre;
    TextField input_apellido;
    VisualElement input_imagen1;
    VisualElement input_imagen2;
    VisualElement input_imagen3;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        plantilla = root.Q("plantilla");

        input_nombre = root.Q<TextField>("InputNombre");
        input_apellido = root.Q<TextField>("InputApellido");

        input_imagen1 = root.Q<VisualElement>("ashe");
        input_imagen2 = root.Q<VisualElement>("ahri");
        input_imagen3 = root.Q<VisualElement>("aphelios");

        plantilla.RegisterCallback<ClickEvent>(SeleccionIndividuo);
        input_nombre.RegisterCallback<ChangeEvent<string>>(CambioNombre);
        input_apellido.RegisterCallback<ChangeEvent<string>>(CambioApellido);
        input_imagen1.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
        input_imagen2.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
        input_imagen3.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
    }

    void SeleccionIndividuo(ClickEvent evt)
    {
        string nombre = plantilla.Q<Label>("Nombre").text;
        string apellido = plantilla.Q<Label>("Apellido").text;

        Debug.Log(nombre);

        input_nombre.SetValueWithoutNotify(nombre);
        input_apellido.SetValueWithoutNotify(apellido);
    }

    void CambioNombre(ChangeEvent<string> evt)
    {
        Label nombreLabel = plantilla.Q<Label>("Nombre");
        nombreLabel.text = evt.newValue;
    }

    void CambioApellido(ChangeEvent<string> evt)
    {
        Label apellidoLabel = plantilla.Q<Label>("Apellido");
        apellidoLabel.text = evt.newValue;
    }

    void CambioImagen(ClickEvent evt)
    {
        VisualElement auximg = evt.target as VisualElement;
        Debug.Log(auximg.name);
        VisualElement topImage = plantilla.Q<VisualElement>("top");
        topImage.RemoveFromClassList("FotoAkali");
        topImage.RemoveFromClassList("FotoAhri");
        topImage.RemoveFromClassList("FotoAphelios");
        topImage.RemoveFromClassList("FotoAshe");
        
        switch (auximg.name)
        {
            case "ashe":
                topImage.AddToClassList("FotoAshe");
                break;
            case "ahri":
                topImage.AddToClassList("FotoAhri");
                break;
            case "aphelios":
                topImage.AddToClassList("FotoAphelios");
                break;

        }

    }
}
