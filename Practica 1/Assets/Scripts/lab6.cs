using Lab5b_namespace;
using Lab6_namespace;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lab6_namespace
{
    public class Lab6 : MonoBehaviour
    {
        VisualElement botonCrear;
        Toggle toggleModificar;
        VisualElement contenedor_dcha;
        TextField input_nombre;
        TextField input_apellido;
        Individuo individuoSelec;

        List<Individuo> list_individuos = new List<Individuo>(); //serializacion en formato json 

        private void OnEnable()
        {
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            contenedor_dcha = root.Q<VisualElement>("derecha");
            input_nombre = root.Q<TextField>("InputNombre");
            input_apellido = root.Q<TextField>("InputApellido");
            botonCrear = root.Q<Button>("BotonCrear");
            toggleModificar = root.Q<Toggle>("ToggleModificar");

            contenedor_dcha.RegisterCallback<ClickEvent>(seleccionTarjeta);
            botonCrear.RegisterCallback<ClickEvent>(NuevaTarjeta);
            input_nombre.RegisterCallback<ChangeEvent<string>>(CambioNombre);
            input_apellido.RegisterCallback<ChangeEvent<string>>(CambioApellido);
        }

        void NuevaTarjeta(ClickEvent evt)
        {
            if (!toggleModificar.value)
            {
                VisualTreeAsset plantilla = Resources.Load<VisualTreeAsset>("TarjetaP6");
                Debug.Log(plantilla);
                VisualElement tarjetaPlantilla = plantilla.Instantiate();

                contenedor_dcha.Add(tarjetaPlantilla);

                bordeNegro();
                bordeBlanco(tarjetaPlantilla);

                Individuo individuo = new Individuo(input_nombre.value, input_apellido.value);
                Tarjeta tarjeta = new Tarjeta(tarjetaPlantilla, individuo);
                individuoSelec = individuo;

                

                //serializacion en formato json 
                /*
                list_individuos.Add(individuo);
                list_individuos.ForEach(elem => {
                    Debug.Log(elem.Nombre + " " + elem.Apellido);
                    string jsonIndividuo = JsonUtility.ToJson(elem);
                    Debug.Log(jsonIndividuo);
                });
                 */
            }
        }

        void seleccionTarjeta(ClickEvent e)
        {
            VisualElement miTarjeta = e.target as VisualElement;
            individuoSelec = miTarjeta.userData as Individuo;



            Debug.Log(miTarjeta.name);
            Debug.Log(individuoSelec);
            Debug.Log(input_nombre.name);
            

            input_nombre.SetValueWithoutNotify(individuoSelec.Nombre);
            input_apellido.SetValueWithoutNotify(individuoSelec.Apellido);
            toggleModificar.value = true;

            bordeNegro();
            bordeBlanco(miTarjeta);
        }

        void CambioNombre(ChangeEvent<string> evt)
        {
            if (toggleModificar.value)
            {
                individuoSelec.Nombre = evt.newValue;
            }
        }

        void CambioApellido(ChangeEvent<string> evt)
        {
            if (toggleModificar.value)
            {
                individuoSelec.Apellido = evt.newValue;
            }
        }

        void bordeNegro()
        {
            List<VisualElement> lt = contenedor_dcha.Children().ToList();
            lt.ForEach(e =>
            {
                VisualElement t = e.Q("Tarjeta1");

                t.style.borderLeftColor = Color.black;
                t.style.borderRightColor = Color.black;
                t.style.borderBottomColor = Color.black;
                t.style.borderTopColor = Color.black;

                t.style.borderRightWidth = 5;
                t.style.borderLeftWidth = 5;
                t.style.borderBottomWidth = 5;
                t.style.borderTopWidth = 5;

            });
        }
        void bordeBlanco(VisualElement tarj)
        {
            VisualElement t = tarj.Q("Tarjeta1");
            
            t.style.borderTopColor = Color.white;
            t.style.borderBottomColor = Color.white;
            t.style.borderLeftColor = Color.white;
            t.style.borderRightColor = Color.white;


            t.style.borderRightWidth = 5;
            t.style.borderLeftWidth = 5;
            t.style.borderBottomWidth = 5;
            t.style.borderTopWidth = 5;
        }
    }
}