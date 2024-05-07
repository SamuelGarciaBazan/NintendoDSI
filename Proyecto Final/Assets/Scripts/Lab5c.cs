using Lab5b_namespace;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lab5c_namespace
{
    public class Lab5c : MonoBehaviour
    {
        VisualElement info;

        List<Individuo> individuos;
        Individuo selectIndividuo;

        //VisualElement tarjeta1;

        //TextField input_nombre;
        //TextField input_apellido;

        #region InputImagenes
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
        #endregion

        Label rol1;
        Label nombre;
        Label descripcionPersonaje;
        Label rol2;
        Label descripcionRol;

        VisualElement topImage;

        private void OnEnable()
        {
            Debug.Log("OnEnable");

            VisualElement root = GetComponent<UIDocument>().rootVisualElement;
            info = root.Q("Info");

            topImage = root.Q<VisualElement>("IconPro");

            rol1 = root.Q<Label>("Rol1");
            nombre = root.Q<Label>("Nombre");
            descripcionPersonaje = root.Q<Label>("DescripcionPersonaje");
            rol2 = root.Q<Label>("Rol2");
            descripcionRol = root.Q<Label>("DescripcionRol");


            individuos = BaseDatos.getData();

            // VisualElement panelDcha = root.Q("derecha");
            // panelDcha.RegisterCallback<ClickEvent>(seleccionTarjeta);

            //rol1.RegisterCallback<ChangeEvent<string>>(CambioRol1);
            //nombre.RegisterCallback<ChangeEvent<string>>(CambioNombre);
            //descripcionPersonaje.RegisterCallback<ChangeEvent<string>>(CambioDescripcionPersonaje);
            //rol2.RegisterCallback<ChangeEvent<string>>(CambioRol2);
            //descripcionRol.RegisterCallback<ChangeEvent<string>>(CambioDescripcionRol);

            #region InputImagenes
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
            #endregion

            InitizalizeUI();
        }

        void InitizalizeUI()
        {
            Debug.Log("InitizalizeUI");
            selectIndividuo = individuos[0];
            Tarjeta informacion = new Tarjeta(info, selectIndividuo);
        }

        void CambioRol1(ChangeEvent<string> evt)
        {
            Label Rol1 = info.Q<Label>("Rol1");
            Rol1.text = evt.newValue;
        }

        void CambioNombre(ChangeEvent<string> evt)
        {
            Label Nombre = info.Q<Label>("Nombre");
            Nombre.text = evt.newValue;
        }

        void CambioDescripcionPersonaje(ChangeEvent<string> evt)
        {
            Label DescripcionPersonaje = info.Q<Label>("DescripcionPersonaje");
            DescripcionPersonaje.text = evt.newValue;
        }

        void CambioRol2(ChangeEvent<string> evt)
        {
            Label Rol2 = info.Q<Label>("Rol2");
            Rol2.text = evt.newValue;
        }

        void CambioDescripcionRol(ChangeEvent<string> evt)
        {
            Label DescripcionRol = info.Q<Label>("DescripcionRol");
            DescripcionRol.text = evt.newValue;
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
                    CambioInfo(0);
                    break;
                case "breach":
                    topImage.AddToClassList("breach");
                    CambioInfo(1);
                    break;
                case "brimstome":
                    topImage.AddToClassList("brimstome");
                    CambioInfo(2);
                    break;
                case "chamber":
                    topImage.AddToClassList("chamber");
                    CambioInfo(3);
                    break;
                case "clove":
                    topImage.AddToClassList("clove");
                    CambioInfo(4);
                    break;
                case "cypher":
                    topImage.AddToClassList("cypher");
                    CambioInfo(5);
                    break;
                case "deadlock":
                    topImage.AddToClassList("deadlock");
                    CambioInfo(6);
                    break;
                case "fade":
                    topImage.AddToClassList("fade");
                    CambioInfo(7);
                    break;
                case "gekko":
                    topImage.AddToClassList("gekko");
                    CambioInfo(8);
                    break;
                case "harbor":
                    topImage.AddToClassList("harbor");
                    CambioInfo(9);
                    break;
                case "iso":
                    topImage.AddToClassList("iso");
                    CambioInfo(10);
                    break;
                case "jett":
                    topImage.AddToClassList("jett");
                    CambioInfo(11);
                    break;
                case "kayo":
                    topImage.AddToClassList("kayo");
                    CambioInfo(12);
                    break;
                case "killjoy":
                    topImage.AddToClassList("killjoy");
                    CambioInfo(13);
                    break;
                case "neon":
                    topImage.AddToClassList("neon");
                    CambioInfo(14);
                    break;
                case "omen":
                    topImage.AddToClassList("omen");
                    CambioInfo(15);
                    break;
                case "phoenix":
                    topImage.AddToClassList("phoenix");
                    CambioInfo(16);
                    break;
                case "raze":
                    topImage.AddToClassList("raze");
                    CambioInfo(17);
                    break;
                case "reyna":
                    topImage.AddToClassList("reyna");
                    CambioInfo(18);
                    break;
                case "sage":
                    topImage.AddToClassList("sage");
                    CambioInfo(19);
                    break;

            }

        }

        void CambioInfo(int i)
        {
            selectIndividuo.Rol1 = individuos[i].Rol1;
            selectIndividuo.Nombre = individuos[i].Nombre;
            selectIndividuo.DescripcionPersonaje = individuos[i].DescripcionPersonaje;
            selectIndividuo.Rol2 = individuos[i].Rol2;
            selectIndividuo.DescripcionRol = individuos[i].DescripcionRol;
        }
    }
}