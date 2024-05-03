using Lab5b_namespace;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lab5c_namespace
{
    public class Lab5c : MonoBehaviour
    {
        List<Individuo> individuos;
        Individuo selectIndividuo;

        VisualElement tarjeta1;
        VisualElement tarjeta2;
        VisualElement tarjeta3;
        VisualElement tarjeta4;

        TextField input_nombre;
        TextField input_apellido;

        VisualElement input_imagen1;
        VisualElement input_imagen2;
        VisualElement input_imagen3;

        VisualElement topImage;

        private void OnEnable()
        {
            Debug.Log("OnEnable");

            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            tarjeta1 = root.Q("Tarjeta1");
            tarjeta2 = root.Q("Tarjeta2");
            tarjeta3 = root.Q("Tarjeta3");
            tarjeta4 = root.Q("Tarjeta4");

            input_nombre = root.Q<TextField>("InputNombre");
            input_apellido = root.Q<TextField>("InputApellido");


            individuos = BaseDatos.getData();

            VisualElement panelDcha = root.Q("derecha");
            panelDcha.RegisterCallback<ClickEvent>(seleccionTarjeta);

            input_nombre.RegisterCallback<ChangeEvent<string>>(CambioNombre);
            input_apellido.RegisterCallback<ChangeEvent<string>>(CambioApellido);

            input_imagen1 = root.Q<VisualElement>("ashe");
            input_imagen2 = root.Q<VisualElement>("ahri");
            input_imagen3 = root.Q<VisualElement>("aphelios");

            input_imagen1.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen2.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen3.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent

            InitizalizeUI();
        }

        void CambioNombre(ChangeEvent<string> evt)
        {
            selectIndividuo.Rol1 = evt.newValue;
        }

        void CambioApellido(ChangeEvent<string> evt)
        {
            selectIndividuo.Nombre = evt.newValue;
        }

        void seleccionTarjeta(ClickEvent e)
        {
            Debug.Log("Selección Tarjeta");
            VisualElement tarjeta = e.target as VisualElement;
            selectIndividuo = tarjeta.userData as Individuo;

            Debug.Log(selectIndividuo.Rol1);
            input_nombre.SetValueWithoutNotify(selectIndividuo.Rol1);
            input_apellido.SetValueWithoutNotify(selectIndividuo.Nombre);
            topImage = tarjeta.Q<VisualElement>("top");
        }

        void InitizalizeUI()
        {
            Tarjeta tar1 = new Tarjeta(tarjeta1, individuos[0]);
            Tarjeta tar2 = new Tarjeta(tarjeta2, individuos[1]);
            Tarjeta tar3 = new Tarjeta(tarjeta3, individuos[2]);
            Tarjeta tar4 = new Tarjeta(tarjeta4, individuos[3]);
        }

        void CambioImagen(ClickEvent evt)
        {
            VisualElement auximg = evt.target as VisualElement;
            Debug.Log(auximg.name);
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
}