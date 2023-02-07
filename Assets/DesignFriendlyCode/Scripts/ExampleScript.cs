using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BjPoyser.DesignFriendlyCode
{
    //The component will be added automatically, if the current gameObject doesn't have it assingned
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(BoxCollider2D))]

    //Avoids having this script multiple times in the same GameObject
    [DisallowMultipleComponent]

    //Allows to execute Update and Awake in the editor mode
    [ExecuteInEditMode]

    //You can attach online documentation to this class
    [HelpURL("https://bjpoyser.me/#/")]
    public class ExampleScript : MonoBehaviour
    {
        //Context Menu makes visible this function in the inspector
        //Allowing us to execute it from the edit mode
        [ContextMenu("Test this function")]
        void TestFunction()
        {
            Debug.Log("test");
        }

        //Header is a title in the inspector
        //Helps to separate in sections your variables
        //You can have multiple headers. They will be ordered first in, last out
        [Header("Information")] 
        [Header("Information2")]

        //SerializeField allows to see private and protected variables in the inspector
        [SerializeField] private string objectName;

        //Only by creating an enum variable visible in the inspector a dropdown menu will be displayed
        [SerializeField] protected GlobalVariables.ObjectColor _customColor = GlobalVariables.ObjectColor.r;
        
        //Tool Tip allows us to add a description to this variable.
        //If you hover with the mouse this variable in the inspector, you can see whatever is in-between the parenthesis
        [Tooltip("Enables/Disables the image component, making not visible the object")]
        [SerializeField] private bool _objectIsVisible = true;

        //Adds a space in the inspector. The number in-between the parenthesis is the height in pixels
        [Space(10)]

        [Header("Stats")]

        //Range adds a slidder to handle this variable. Can be an integer variable
        [Range(10, 20)] public int age;

        //Or a variable with decimals
        [Range(5.5f, 8.5f)] 
        [SerializeField] private float _speed;
        [Range(3f, 5.5f)]
        [SerializeField] private decimal _jumpForce;

        //Hide In Inspector avoids the variable to be shown in the inspector
        [HideInInspector] public int objectID;
        [Space(50)]

        //Text Area shows a bigger field to write whatever you want
        //You can set a min and max number of visible lines (min, max)
        [TextArea(1,10)][SerializeField] private string _dialog;
        [Space(50)]

        //Min restricst the minimun value that can be set in the variable
        //Works with decimals and integers
        [Min(15.5f)] public float _timeToRespawn;
        [Min(7)] public int _minLives;

        private void Update()
        {
            //Execute only in editor mode
            if (!Application.isPlaying)
            {
                UpdateColor();
            }
        }

        /// <summary>
        /// Updates the image color of the GameObject that has this script assigned
        /// </summary>
        private void UpdateColor()
        {
            Image image = GetComponent<Image>();
            if (image != null)
            {
                image.enabled = _objectIsVisible;

                //Switch using direct reference
                switch (_customColor)
                {
                    case GlobalVariables.ObjectColor.r:
                        GetComponent<Image>().color = Color.red;
                        break;
                    case GlobalVariables.ObjectColor.g:
                        GetComponent<Image>().color = Color.green;
                        break;
                    case GlobalVariables.ObjectColor.b:
                        GetComponent<Image>().color = Color.blue;
                        break;
                }

                /*
                //Switch using index
                int colorIndex = (int)_customColor;

                switch (colorIndex)
                {
                    case 0:
                        GetComponent<Image>().color = Color.red;
                        break;
                    case 1:
                        GetComponent<Image>().color = Color.green;
                        break;
                    case 2:
                        GetComponent<Image>().color = Color.blue;
                        break;
                }
                */
            }
        }
    }
}

