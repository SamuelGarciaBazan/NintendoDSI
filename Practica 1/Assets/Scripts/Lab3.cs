using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.ObjectChangeEventStream;

public class Lab3 : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        UQueryBuilder<VisualElement> builder = new(root);

        List<VisualElement> contenedor = builder.Name("Icon").ToList();

        contenedor.ForEach(c => c.AddManipulator(new Lab3Manipulator()));

        contenedor.ForEach(c => c.AddManipulator(new ExampleResizer()));
    }
   
}
