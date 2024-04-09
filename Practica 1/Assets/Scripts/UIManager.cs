using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    private UIDocument ui_;

    private void OnEnable()
    {
        ui_ = GetComponent<UIDocument>();
        VisualElement rootve = ui_.rootVisualElement;

        UQueryBuilder<VisualElement> builder = new(rootve);

        //elemento del texto de seleccion de campeon
        VisualElement contenedor = builder.Name("SelectText2427");

        //todos los elemtos con la clase "textFont"
        VisualElement contenedor2 = builder.Class("textFont");

        //listas de elementos
        List<VisualElement> visualElements = contenedor.Children().ToList();
        List<VisualElement> visualElements2 = builder.Class("textFont").ToList();


        //el texto de seleccion de campeon pasa a tener la clase "textFont"
        visualElements.ForEach(elem =>
        {
            Debug.Log(elem.name);
            elem.AddToClassList("textFont");
        });


        //todos los elementos pierden la clase "textFont" y se les anade "textFontRed"
        visualElements2.ForEach(elem =>
        {
            Debug.Log(elem.name);

            elem.RemoveFromClassList("textFont");
            elem.AddToClassList("textFontRed");
        });
    }

    private void Start()
    {
    }
}
