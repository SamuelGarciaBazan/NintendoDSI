using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;


namespace Lab5b_namespace
{
    public class Tarjeta
    {
        Individuo miIndividuo;
        VisualElement tarjetaRoot;

        //Label nombreLabel;
        //Label apellidoLabel;

        Label rol1;
        Label nombre;
        Label descripcionPersonaje;
        Label rol2;
        Label descripcionRol;

        public Tarjeta(VisualElement tarjetaRoot, Individuo individuo)
        {
            this.tarjetaRoot = tarjetaRoot;
            this.miIndividuo = individuo;

            //nombreLabel = tarjetaRoot.Q<Label>("Nombre");
            //apellidoLabel = tarjetaRoot.Q<Label>("Apellido");

            rol1 = tarjetaRoot.Q<Label>("Rol1");
            nombre = tarjetaRoot.Q<Label>("Nombre");
            descripcionPersonaje = tarjetaRoot.Q<Label>("DescripcionPersonaje");
            rol2 = tarjetaRoot.Q<Label>("Rol2");
            descripcionRol = tarjetaRoot.Q<Label>("DescripcionRol");

            tarjetaRoot.userData = miIndividuo;

            tarjetaRoot.
                Query(className: "Tarjeta")
                .Descendents<VisualElement>()
                .ForEach(elem => elem.pickingMode = PickingMode.Ignore);

            UpdateUI();

            miIndividuo.Cambio += UpdateUI;
        }

        void UpdateUI()
        {
            rol1.text = miIndividuo.Rol1;
            nombre.text = miIndividuo.Nombre;
            descripcionPersonaje.text = miIndividuo.DescripcionPersonaje;
            rol2.text = miIndividuo.Rol2;
            descripcionRol.text = miIndividuo.DescripcionRol;
        }
    }
}