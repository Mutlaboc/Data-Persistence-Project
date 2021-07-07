using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameStoreUnit : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public static NameStoreUnit Instance;

    private void Awake()
    {

            // start of new code
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }
            // end of new code

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    public void StoreName()

    {
        theName = inputField.GetComponent<Text>().text;
    }

}
