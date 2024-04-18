using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lab5b_namespace
{
    public class Individuo
    {
        public event Action Cambio;

        private string nombre;
        public string Nombre
        {
            get { return nombre; }

            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    Cambio?.Invoke();

                }
            }
        }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }

            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    Cambio?.Invoke();

                }
            }
        }
    }
}
