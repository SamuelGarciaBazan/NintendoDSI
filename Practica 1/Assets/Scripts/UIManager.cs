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

        VisualElement contenedor = builder.Name("SelectText");
        VisualElement contenedor2 = builder.Class("textFont");

        List<VisualElement> visualElements = contenedor.Children().ToList();
        List<VisualElement> visualElements2 = builder.Class("textFont").ToList();

        visualElements.ForEach(elem =>
        {
            Debug.Log(elem.name);
            elem.AddToClassList("textFont");
        });

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
