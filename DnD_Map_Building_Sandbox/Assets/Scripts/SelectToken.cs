using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SelectToken : NetworkBehaviour
{
    // Public Variables
    public bool Highlighted;
    static GameObject selectedToken;
    static List<GameObject> TokenArrows;

    // Start is called before the first frame update
    void Start()
    {
        Highlighted = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Correctly Uses raycasts to select gameobject

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Click is down");

            RaycastHit hitInfo = new RaycastHit();

            bool isHitting = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (isHitting && hitInfo.transform.gameObject.tag == "Token")
            {
                Debug.Log("Ray hit " + hitInfo.transform.gameObject.name);

                if (hitInfo.transform.gameObject.tag == "Token")
                {
                    Debug.Log("Raycast Targeting detected a Token");

                    selectedToken = hitInfo.transform.gameObject;

                    Highlighted = !Highlighted;

                    hitInfo.transform.gameObject.transform.GetChild(0).transform.gameObject.SetActive(Highlighted);
                }

                else
                {
                    Debug.LogError("Raycast Targeting is not working");
                }
            }

            else
            {
                Debug.Log("Ray hit: " + hitInfo.transform.gameObject.name);
            }
        }
    }

    public static GameObject GetSelectedToken()
    {
        return selectedToken;
    }

    public static List<GameObject> GetSelectedTokenArrows()
    {
        return TokenArrows;
    }
}
