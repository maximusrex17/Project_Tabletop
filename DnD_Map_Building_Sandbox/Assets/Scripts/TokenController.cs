using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TokenController : NetworkBehaviour
{

    GameObject Token;
    List<GameObject> Arrows;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Token = SelectToken.GetSelectedToken();

        if (!isLocalPlayer && !isServer)
        {
            // Exit from update if this is not the local player
            return;
        }
               
        Vector3 tempVec = new Vector3();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            tempVec.z += 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            tempVec.z -= 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            tempVec.x += 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tempVec.x -= 1.0f;
        }

        if (Token != null)
        {
            Token.transform.position += new Vector3(tempVec.x, 0.0f, tempVec.z);
        }
    }
}
