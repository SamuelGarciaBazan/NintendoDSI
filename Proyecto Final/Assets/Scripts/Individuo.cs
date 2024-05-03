using UnityEngine;
using System;


namespace Lab5b_namespace
{
    public class Individuo
    {
        public event Action Cambio;

        private string rol1;
        public string Rol1
        {
            get { return rol1; }
            set
            {
                if (value != rol1)
                {
                    rol1 = value;
                    Cambio?.Invoke();
                }
            }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != nombre)
                {
                    nombre = value;
                    Cambio?.Invoke();
                }
            }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (value != descripcion)
                {
                    descripcion = value;
                    Cambio?.Invoke();
                }
            }
        }

        private string rol2;
        public string Rol2
        {
            get { return rol2; }
            set
            {
                if (value != rol2)
                {
                    rol2 = value;
                    Cambio?.Invoke();
                }
            }
        }

        private string descripcionRol;
        public string DescripcionRol
        {
            get { return descripcionRol; }
            set
            {
                if (value != descripcionRol)
                {
                    descripcionRol = value;
                    Cambio?.Invoke();
                }
            }
        }

        public Individuo(string rol1, string nombre, string rol2, string descripcionRol)
        {
            this.rol1 = rol1;
            this.nombre = nombre;
            this.rol2 = rol2;
            this.descripcionRol = descripcionRol;
        }
    }
}