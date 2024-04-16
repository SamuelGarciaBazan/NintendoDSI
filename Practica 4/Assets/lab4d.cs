using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class lab4d : VisualElement
{
    public new class UxmlFactory : UxmlFactory<lab4d,UxmlTraits> { }

    public new class UxmlTraits : VisualElement.UxmlTraits
    {

        UxmlIntAttributeDescription numb = new UxmlIntAttributeDescription { name=  "Items", defaultValue = 0 };

        public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
        {
            base.Init(ve, bag, cc);

            var semaforo = ve as lab4d;
            semaforo.Items = numb.GetValueFromBag(bag, cc);
            Debug.Log("N Items : " + semaforo.Items);

        }
    }

    public Background style;

    int nItems;
    public int Items
    {
        get =>nItems; 
        set {
            nItems = value;
            prueba();
        } 
    }
    
    List<VisualElement> items = new List<VisualElement>();

    public lab4d() {

        string image = "";

        //style = Resources.Load<StyleSheet>("Images/espada").ConvertTo<StyleBackground>();
        
        VisualElement item;
        for (int i = 0; i < 5; i++)
        {
            item  = new VisualElement();

            item.style.width = 100;
            item.style.height = 100;
            item.name = "item" + i.ToString();  
            item.style.backgroundColor = Color.white;   
            //item.style.backgroundImage = style;   
            items.Add(item);

            hierarchy.Add(item);
        }

        
    }

    void prueba()
    {

        VisualElement item;

        for(int i = 0; i < 5; i++)
        {
            items[i].style.backgroundColor = Color.white;
        }

        for (int i = 0; i < Mathf.Min(nItems,5) ; i++)
        {
            items[i].style.backgroundColor = Color.green;
        }
    }
}
