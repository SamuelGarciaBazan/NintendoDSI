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

        TextField input_nombre;
        TextField input_apellido;

        VisualElement input_imagen1;
        VisualElement input_imagen2;
        VisualElement input_imagen3;
        VisualElement input_imagen4;
        VisualElement input_imagen5;
        VisualElement input_imagen6;
        VisualElement input_imagen7;
        VisualElement input_imagen8;
        VisualElement input_imagen9;
        VisualElement input_imagen10;
        VisualElement input_imagen11;
        VisualElement input_imagen12;
        VisualElement input_imagen13;
        VisualElement input_imagen14;
        VisualElement input_imagen15;
        VisualElement input_imagen16;
        VisualElement input_imagen17;
        VisualElement input_imagen18;
        VisualElement input_imagen19;
        VisualElement input_imagen20;

        VisualElement topImage;

        private void OnEnable()
        {
            Debug.Log("OnEnable");

            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            topImage = root.Q<VisualElement>("IconPro");
            //input_nombre = root.Q<TextField>("InputNombre");


            //individuos = BaseDatos.getData();

            // VisualElement panelDcha = root.Q("derecha");
            // panelDcha.RegisterCallback<ClickEvent>(seleccionTarjeta);


            input_imagen1 = root.Q<VisualElement>("astra");
            input_imagen2 = root.Q<VisualElement>("breach");
            input_imagen3 = root.Q<VisualElement>("brimstome");
            input_imagen4 = root.Q<VisualElement>("chamber");
            input_imagen5 = root.Q<VisualElement>("clove");
            input_imagen6 = root.Q<VisualElement>("cypher");
            input_imagen7 = root.Q<VisualElement>("deadlock");
            input_imagen8 = root.Q<VisualElement>("fade");
            input_imagen9 = root.Q<VisualElement>("gekko");
            input_imagen10 = root.Q<VisualElement>("harbor");
            input_imagen11 = root.Q<VisualElement>("iso");
            input_imagen12 = root.Q<VisualElement>("jett");
            input_imagen13 = root.Q<VisualElement>("kayo");
            input_imagen14 = root.Q<VisualElement>("killjoy");
            input_imagen15 = root.Q<VisualElement>("neon");
            input_imagen16 = root.Q<VisualElement>("omen");
            input_imagen17 = root.Q<VisualElement>("phoenix");
            input_imagen18 = root.Q<VisualElement>("raze");
            input_imagen19 = root.Q<VisualElement>("reyna");
            input_imagen20 = root.Q<VisualElement>("sage");

            input_imagen1.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen2.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen3.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen4.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen5.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen6.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen7.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen8.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen9.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen10.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen11.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen12.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen13.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen14.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen15.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen16.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen17.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen18.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen19.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent
            input_imagen20.RegisterCallback<ClickEvent>(CambioImagen); // Cambiamos el evento a MouseUpEvent

            InitizalizeUI();
        }

        void InitizalizeUI()
        {
            //Tarjeta tar1 = new Tarjeta(tarjeta1, individuos[0]);
        }

        void CambioImagen(ClickEvent evt)
        {
            VisualElement auximg = evt.target as VisualElement;
            Debug.Log(auximg.name);
            topImage.RemoveFromClassList("astra");
            topImage.RemoveFromClassList("breach");
            topImage.RemoveFromClassList("brimstome");
            topImage.RemoveFromClassList("chamber");
            topImage.RemoveFromClassList("clove");
            topImage.RemoveFromClassList("cypher");
            topImage.RemoveFromClassList("deadlock");
            topImage.RemoveFromClassList("fade");
            topImage.RemoveFromClassList("gekko");
            topImage.RemoveFromClassList("harbor");
            topImage.RemoveFromClassList("iso");
            topImage.RemoveFromClassList("jett");
            topImage.RemoveFromClassList("kayo");
            topImage.RemoveFromClassList("killjoy");
            topImage.RemoveFromClassList("neon");
            topImage.RemoveFromClassList("omen");
            topImage.RemoveFromClassList("phoenix");
            topImage.RemoveFromClassList("raze");
            topImage.RemoveFromClassList("reyna");
            topImage.RemoveFromClassList("sage");

            switch (auximg.name)
            {
                case "astra":
                    topImage.AddToClassList("astra");
                    break;
                case "breach":
                    topImage.AddToClassList("breach");
                    break;
                case "brimstome":
                    topImage.AddToClassList("brimstome");
                    break;
                case "chamber":
                    topImage.AddToClassList("chamber");
                    break;
                case "clove":
                    topImage.AddToClassList("clove");
                    break;
                case "cypher":
                    topImage.AddToClassList("cypher");
                    break;
                case "deadlock":
                    topImage.AddToClassList("deadlock");
                    break;
                case "fade":
                    topImage.AddToClassList("fade");
                    break;
                case "gekko":
                    topImage.AddToClassList("gekko");
                    break;
                case "harbor":
                    topImage.AddToClassList("harbor");
                    break;
                case "iso":
                    topImage.AddToClassList("iso");
                    break;
                case "jett":
                    topImage.AddToClassList("jett");
                    break;
                case "kayo":
                    topImage.AddToClassList("kayo");
                    break;
                case "killjoy":
                    topImage.AddToClassList("killjoy");
                    break;
                case "neon":
                    topImage.AddToClassList("neon");
                    break;
                case "omen":
                    topImage.AddToClassList("omen");
                    break;
                case "phoenix":
                    topImage.AddToClassList("phoenix");
                    break;
                case "raze":
                    topImage.AddToClassList("raze");
                    break;
                case "reyna":
                    topImage.AddToClassList("reyna");
                    break;
                case "sage":
                    topImage.AddToClassList("sage");
                    break;

            }

        }
    }
}