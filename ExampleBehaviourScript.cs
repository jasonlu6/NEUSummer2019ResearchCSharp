/* 
 * Tutorial for RGB Color for C# Unity coding. 
 * Author: Jason Lu (lu.jaso@husky.neu.edu)
 * Date: 5.01.2019 - 5.05.2019
 * Training Module #2 For NEU Summer Research 2019 
 */

using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Application
{
    public class ExampleBehaviourScript : MonoBehaviour
    {
        void Update()
        {
            /* The Red color key */
            if (Input.GetKeyDown(KeyCode.R))
            {
                GetComponent<Renderer>().material.color = Color.Red;
            }

            /* The Green color key */
            if (Input.GetKeyDown(KeyCode.G))
            {
                GetComponent<Renderer>().material.color = Color.Green;
            }

            /* The Blue color key */
            if (Input.GetKeyDown(KeyCode.B))
            {
                GetComponent<Renderer>().material.color = Color.Blue;
            }
        }
    }
}
