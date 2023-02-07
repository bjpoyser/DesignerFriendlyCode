using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BjPoyser.DesignFriendlyCode
{
    public class GlobalVariables
    {
        // All the items listed here will appear in a dropdown menu in the inspector
        // You can refer to this object by its index as well
        public enum ObjectColor
        {
            //Inspector name overrides the enum name in the inspector
            [InspectorName("Red")]r, //0
            g, //1
            b, //2
        }
    }
}